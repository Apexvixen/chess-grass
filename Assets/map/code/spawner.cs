using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("not jojos")]
    [SerializeField] private GameObject[] enemiesprfb;

    [Header("spawnrate")]
    [SerializeField] int baseEnemies = 10;
    [SerializeField] private float enemyPerSecond = 1.5f;
    [SerializeField] private float timeBetweenWaves = 15f;
    [SerializeField] private float difficultyScalingfactor = 20f;
    private int currentwave = 1;
    private float timeSincelastspawn;
    private int enemiesliving;
    private int enemieleftTospawn;


    private void Start()
    {
            enemieleftTospawn=baseEnemies;

    }
    private int enemiesperwave()
    {
         return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentwave, difficultyScalingfactor));
    }
}
