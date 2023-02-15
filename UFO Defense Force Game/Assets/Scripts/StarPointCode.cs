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

    public float xRange = 30.0f;

    //public gameObject starpoint;

    void Start ()
    {
        InvokeRepeating("StarPointCapsuleSpawn", startDelay, spawnInterval);
    }

    void StarPointCapsuleSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange),0,22);

        Instantiate(StarPointCapsule, spawnPos, StarPointCapsule.transform.rotation);
    }

    // move the starpoint
    void Update()
    {
        
        //Moves down the Screen
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    // private void OnTriggerEnter(Collider collision)
    // {
    //     Destroy(gameObject);

    //     if (gameObject == null)
    //     {
    //         points ++;
    //     }
    // }

}
