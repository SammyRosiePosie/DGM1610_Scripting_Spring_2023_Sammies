using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointCode : MonoBehaviour
{
    public int points = 0;
    
    public float speed = 0.50f;

    public GameObject StarPointCapsule;

    public float startDelay = 1.5f;

    public float spawnInterval = 10.0f;

    public float xRange = 20.0f;

    private float spawnPosZ = 20f;

    //public gameObject starpoint;

    void Start ()
    {
        InvokeRepeating("StarPointCapsuleSpawn", startDelay, spawnInterval);
    }

    void StarPointCapsuleSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange),0,spawnPosZ);

        Instantiate(StarPointCapsule, spawnPos, StarPointCapsule.transform.rotation);
    }

    // move the starpoint
    void Update()
    {
        
        //Moves down the Screen
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(this.gameObject);

        // if (gameObject == null)
        // {
        //     points ++;
        // }
    }

}
