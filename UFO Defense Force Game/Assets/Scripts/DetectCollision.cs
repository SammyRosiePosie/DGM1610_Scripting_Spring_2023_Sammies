using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destoy this gameobject
        Destroy(other.gameObject); //Destory the other gameobject it hits
        
    }
}
