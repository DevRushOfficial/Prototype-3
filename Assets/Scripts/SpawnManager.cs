using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 _spawnPosition = new Vector3(15, 0, 0);
    private float _startDelay = 2;
    private float _repeatRate = 2;

    void Start()
    {
        InvokeRepeating("SpawnObstacles", _startDelay, _repeatRate);
    }

    void SpawnObstacles()
    {
        Instantiate(obstaclePrefab, _spawnPosition, obstaclePrefab.transform.rotation);
    }
}
