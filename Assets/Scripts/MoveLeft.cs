using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 15;

    void Update() => transform.Translate(Vector3.left * Time.deltaTime * _speed);
}
