using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; //A variable to hold the reference to the scoremanager
    
    public int scoreToGive;
    
    public ParticleSystem explosionParticle; //Store the particle system

    private AudioSource explosionAudio;
    public AudioClip explosionBoom;

    void Start()
    {
       scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Reference scoremanager
       explosionAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LazerBolt"))
        {
            Destroy(gameObject); //Destoy this gameobject
            Destroy(other.gameObject); //Destory the other gameobject it hits
            explosionAudio.PlayOneShot(explosionBoom,1.0f);
            Explosion();
        }
       
        scoreManager.IncreaseScore(scoreToGive); //Increase Score
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }

    
}
