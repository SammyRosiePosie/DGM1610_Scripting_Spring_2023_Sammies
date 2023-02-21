using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefrabs; //Array to store UFO ships

    private float spawnRangeX = 20f;
   
    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
        int ufoIndex = Random.Range(0,ufoPrefrabs.Length); //Picks a random UFP from the array
            
        Instantiate(ufoPrefrabs[ufoIndex],spawnPos, ufoPrefrabs[ufoIndex].transform.rotation); //Spawns a indexed UFO form the array at a rendom location the x-axis
    }
}
