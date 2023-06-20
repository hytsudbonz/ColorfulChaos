using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //Enemy Spawn
    [SerializeField] GameObject enemyPrefab;
    float posX;
    float posY;
    float enemyCount;
    int spawnCount = 1;
    //Powerup spawn
    [SerializeField] GameObject powerupPrefab;
    private void Start()
    {
        SpawnEnemyWave(5);
    }
    private void Update()
    {
        enemyCount = FindObjectsOfType<EnemyBehaviour>().Length;
        if (enemyCount == 0)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
            SpawnEnemyWave(spawnCount);
            spawnCount++;
        }
    }
    void SpawnEnemyWave(int enemy)
    {
        for (int i = 0; i < enemy; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
    Vector3 GenerateSpawnPosition()
    {
        posX = Random.Range(-20f, 20f);
        posY = Random.Range(-20f, 20f);
        Vector3 randomPos = new Vector3(posX, posY, 0);
        return randomPos;
    }
}
