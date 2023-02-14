using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointPickup : MonoBehaviour
{
    public int StarPointValue = 1;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
    }
}
