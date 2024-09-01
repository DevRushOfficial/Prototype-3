using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 10;
    [SerializeField]
    private float _gravityModifier = 1;

    private Rigidbody _playerRb;
    private PlayerAnimator _playerAnimator;

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
        Physics.gravity *= _gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _playerRb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isOnGround = false;
            _playerAnimator.TriggerJumpAnimation();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            _playerAnimator.TriggerDeathAnimation();
            Debug.Log("Game is over!");
            _gameOver = true;
        }
    }
}
