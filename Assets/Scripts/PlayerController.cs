using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 10;
    [SerializeField]
    private float _gravityModifier = 1;
    private Rigidbody _playerRb;

    private bool _isOnGround = true;
    public bool _gameOver;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= _gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _playerRb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isOnGround = false;
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
            _gameOver = true;
            Debug.Log("Game is over!");
        }
    }
}
