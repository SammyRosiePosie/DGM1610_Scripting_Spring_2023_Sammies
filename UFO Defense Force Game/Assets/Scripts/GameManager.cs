using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public bool isGameOver;

   private GameObject gameOverText;

   private AudioSource endGameExplosionSound;
   public AudioClip endGameExplosion;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        endGameExplosionSound = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); //Start EndGame Method
            endGameExplosionSound.PlayOneShot(endGameExplosion, 1.0f);
        }
        else
        {
            gameOverText.gameObject.SetActive(false); //Keep UI Text Game Over Hidden
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //Make game over text appear
        Time.timeScale = 0; //Freeze Time
    }
}
