using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRangeX = 9;
    private float spawnZMin = 15;
    private float spawnZMax = 25;
    public int enemyCount;
    public int waveCount = 1;
    public float enemySpeedIncrease = 0.5f;

    void Start()
    {
        SpawnEnemyWave(waveCount);
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyX>().Length;

        if (enemyCount == 0)
        {
            waveCount++;
            SpawnEnemyWave(waveCount);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            enemy.GetComponent<EnemyX>().speed += enemySpeedIncrease * waveCount;
        }

        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }
}
