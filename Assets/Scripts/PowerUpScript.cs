using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
    public float minSpawnInterval = 5f;
    public float maxSpawnInterval = 15f;
    public float minY = -3f;
    public float maxY = 3f;
    public Transform leftPaddle;
    public Transform rightPaddle;

    private float nextSpawnTime;
    private float randomSpawnInterval;
    private Transform spawnPaddle;

    private void Start()
    {
        RandomizeSpawnParameters();
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPowerUp();
            RandomizeSpawnParameters();
        }
    }

    void RandomizeSpawnParameters()
    {
        randomSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        nextSpawnTime = Time.time + randomSpawnInterval;
        spawnPaddle = Random.Range(0, 2) == 0 ? leftPaddle : rightPaddle;
    }

    void SpawnPowerUp()
    {
        int randomIndex = Random.Range(0, powerupPrefabs.Length);
        GameObject powerupPrefab = powerupPrefabs[randomIndex];
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(spawnPaddle.position.x, randomY, 0f);
        GameObject powerupObject = Instantiate(powerupPrefab, spawnPosition, Quaternion.identity);

        StartCoroutine(DestroyAfterDelay(powerupObject));
    }

    IEnumerator DestroyAfterDelay(GameObject powerupObject)
    {
        yield return new WaitForSeconds(3f);
        Destroy(powerupObject);
    }
}