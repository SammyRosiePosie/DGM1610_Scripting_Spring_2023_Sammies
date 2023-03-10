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
    public GameManager gameManager;

    //audio variables
    private AudioSource blasterAudio;
    public AudioClip laserBlast;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager Script on GameManager Object
        //Get Audiosource component
        blasterAudio = GetComponent<AudioSource>();
    }

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
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) //*Second condition gameManager.isGameOver prevents the player form shooting after isGameOver becomes true
        {
            blasterAudio.PlayOneShot(laserBlast, 0.05f); //play blasterAudio sound clip
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
