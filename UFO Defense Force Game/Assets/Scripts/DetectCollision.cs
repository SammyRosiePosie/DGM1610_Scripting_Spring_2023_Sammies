using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; //A variable to hold the reference to the scoremanager
    
    public int scoreToGive;
    
    void Start()
    {
       scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Reference scoremanager
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LazerBolt"))
        {
            Destroy(gameObject); //Destoy this gameobject
            Destroy(other.gameObject); //Destory the other gameobject it hits
        }
        
        scoreManager.IncreaseScore(scoreToGive); //Increase Score
    }

    /*
    public ParticleSystem exposionParticle; //Store the particle system
        
    void OnTriggerEnter(Collider other)
    {
        Explosion();
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }

    */
}
