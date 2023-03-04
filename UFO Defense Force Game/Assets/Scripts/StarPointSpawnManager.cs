using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointSpawnManager : MonoBehaviour
{
    public GameObject StarPointCapsule;

    private float spawnRangeX = 20f;
   
    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 10f;

    void Start()
    {
        InvokeRepeating("StarPointCapsuleSpawn", startDelay, spawnInterval);
    }

    void StarPointCapsuleSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, spawnPosZ);
                        
        Instantiate(StarPointCapsule, spawnPos, StarPointCapsule.transform.rotation);
    }
}
