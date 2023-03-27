using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallBlast : MonoBehaviour
{
    public float speed = 30.0f;
    public int damage = 1;
    
    private Rigidbody2D rb;
    public bool isFacingRight = true;
    private PlayerController2D player; 

    // Start is called before the first frame update
    void Start()
    {
        
        //Get Rigidbody Component
        rb = GetComponent<Rigidbody2D>(); 
        player = GameObject.Find("Player").GetComponent<PlayerController2D>();

    }

    // Update is called once per frame
    void Update()
    {
       if(isFacingRight /*&& player.isFacingRight = true*/)
       {
            rb.velocity = transform.right * speed * Time.deltaTime; //This line of code add velocity and make the gameobject move forward
       }
       else if(!isFacingRight /*&& player.isFacingRight = false*/)
       {
            rb.velocity = -transform.right * speed * Time.deltaTime;
       }
       
       //rb.velocity = transform.right * speed * Time.deltaTime; //This line of code add velocity and make the gameobject move forward        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage); //Run the TakeDamage function and apply damage to enemy
        }

        Destroy(gameObject); //Destroy Projectile
    }

    /*
    void Start()
    {
        //Get Rigidbody Component
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime; //This line of code add velocity and make the gameobject move forward
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage); //Run the TakeDamage function and apply damage to enemy
        }

        Destroy(gameObject); //Destroy Projectile
    }
    */
}
