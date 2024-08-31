using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 15;
    private PlayerController _playerController;

    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!_playerController.GameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
    }
}
