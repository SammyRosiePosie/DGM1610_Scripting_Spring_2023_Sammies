using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] balloonPrefabs;

    //balloonPrefabs[0] = RedBalloon;
    //balloonPrefabs[1] = GreenBalloon;
    //balloonPrefabs[2] = BlueBalloon;

    public int balloonIndex;

    public float xSpawnRange;

    public float ySpawnPos;

    public float startDelay = 0.5f;

    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon",startDelay ,spawnInterval);
    }

   void SpawnRandomBalloon()
    {
        //generate the X spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, 0);
        //Vector is x,Y,Z

        //pick a random balloon prefab from the balloon array to spawn
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        //Spawn Random Balloons on the X-Axis
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
