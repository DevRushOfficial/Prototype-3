using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    private Vector3 _spawnPosition = new Vector3(15, 0, 0);

    void Start()
    {
        Instantiate(spawnPrefab, _spawnPosition, spawnPrefab.transform.rotation);
    }

    void Update()
    {
        
    }
}
