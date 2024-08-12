using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    private float _jumpForce = 10;
    private float _gravityModifier;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= _gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
