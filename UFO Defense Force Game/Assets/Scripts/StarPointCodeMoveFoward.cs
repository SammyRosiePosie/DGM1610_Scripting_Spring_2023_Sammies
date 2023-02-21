using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointCodeMoveFoward : MonoBehaviour
{
    public float speed = 0.50f;

    // move the starpoint
    void Update()
    {
        
        //Moves down the Screen
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    }
