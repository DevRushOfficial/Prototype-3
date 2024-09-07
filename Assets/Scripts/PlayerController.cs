using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 10;
    [SerializeField]
    private float _gravityModifier = 1;

    private Rigidbody _playerRb;
    private PlayerAnimator _playerAnimator;
    private SoundGameEffects _soundGameEffects;

    [SerializeField]
    private ParticleSystem _explosionParticle;
    [SerializeField]
    private ParticleSystem _dirtParticle;

    private bool _isOnGround = true;
    private bool _gameOver = false;

    public bool GameOver
    {
        get { return _gameOver; }
        private set { _gameOver = value; }
    }

    void Start()
    {
        _playerAnimator = GetComponent<PlayerAnimator>();
        _playerRb = GetComponent<Rigidbody>();
        _soundGameEffects = GetComponent<SoundGameEffects>();
        Physics.gravity *= _gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround && !_gameOver)
        {
            _playerRb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isOnGround = false;
            _playerAnimator.TriggerJumpAnimation();
            _dirtParticle.Stop();
            _soundGameEffects.PlayJumpSound();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
            _dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            _gameOver = true;
            _playerAnimator.TriggerDeathAnimation();
            _explosionParticle.Play();
            _dirtParticle.Stop();
            _soundGameEffects.PlayCrashSound();
            Debug.Log("Game is over!");
        }
    }
}
