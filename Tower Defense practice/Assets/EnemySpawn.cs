using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    private float waveCountdown = 5f;
    private float enemyCountdown = 1f;
    private float enemys = 1f;

    private void Update()
    {

        waveCountdown -= 1 * Time.deltaTime;

        if (waveCountdown == 0)
        {
            SpawnWave();
        }

    }

    private void SpawnWave()
    {

    }

}
