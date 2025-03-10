using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnRange = 2;
    public float spawnPosX = 4.5f;
    public float startDelay = 5;
    public float spawnInterval = 2.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomObstacle()
    {
        Vector2 spawnPos = new Vector2(spawnPosX, Random.Range(-spawnRange, spawnRange));
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }

}
