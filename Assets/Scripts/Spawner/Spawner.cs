using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float clampxspawn;
    public float spawnTime,calTime = 0;
    public List<GameObject> EnemyList = new List<GameObject>();
    private void Update()
    {
        calTime += Time.deltaTime;
        if (calTime > spawnTime) {
            SpawnEnemyWave();
        }
    }

    private void SpawnEnemyWave()
    {
        
    }
}
