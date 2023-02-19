using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointDetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject); //Destoy this gameobject
    }
}
