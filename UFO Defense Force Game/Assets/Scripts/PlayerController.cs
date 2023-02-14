using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25.0f;

    public float xRange = 30.0f;

    public Transform blaster;

    public GameObject lazerBolt;


    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receave values form keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left, and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player with in bounds
        //Left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
            //Right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //If space bar is pressed fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Create laserbolt at the blaster transform position maintaing the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

    }

    //Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
     }
}
