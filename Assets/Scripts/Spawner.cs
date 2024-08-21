using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Obstacle> obstacles;
    [SerializeField] private float mindelay = 0.2f;
    [SerializeField] private float maxdelay = 2f;
    [SerializeField] private float spawnWidth = 15;

    private void Start()
    {
        StartCoroutine(StartSpawnCycle());
    }

    private IEnumerator StartSpawnCycle()
    {
        while (true)
        {
            SpawnObstacle(obstacles[Random.Range(0, obstacles.Count)]);
            
            yield return new WaitForSeconds(Random.Range(mindelay, maxdelay));
        }
    }

    private void SpawnObstacle(Obstacle prefab)
    {
        Vector3 position = new Vector3(Random.Range(-spawnWidth / 2, spawnWidth / 2), transform.position.y, transform.position.z);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
