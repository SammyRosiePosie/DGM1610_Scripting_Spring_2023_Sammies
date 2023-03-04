using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointDetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; //A variable to hold the reference to the scoremanager
    
    public int bonusPoints;
    
    public ParticleSystem starExplosionParticle; //Store the particle system

    void Start()
    {
       scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Reference scoremanager
    }

   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); //Destoy this gameobject
            StarExplosion();  
        }   

        scoreManager.IncreaseScore(bonusPoints); //Increase Score
    }

    void StarExplosion()
    {
        Instantiate(starExplosionParticle, transform.position, transform.rotation);
    }


}
