using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointOutofBounds : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds = -15.0f;
   
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
