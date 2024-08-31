using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _leftLimit = -3f;

    void Update() => DestroyObstacle();

    private void DestroyObstacle()
    {
        if (transform.position.x <= _leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
