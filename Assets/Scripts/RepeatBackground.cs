using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 _startPosition;
    private float _repeatWidth = 56.4f;

    void Start() => _startPosition = transform.position;

    void Update() => ResetPosition();

    private void ResetPosition()
    {
        if (transform.position.x < _startPosition.x - _repeatWidth)
        {
            transform.position = _startPosition;
        }
    }
}
