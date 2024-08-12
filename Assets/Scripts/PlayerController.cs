using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    [SerializeField]
    private float _jumpForce = 10;
    [SerializeField]
    private float _gravityModifier = 1;
    private bool _isOnGround = true;

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

    void OnCollisionEnter(Collision collision) => _isOnGround = true;
}
