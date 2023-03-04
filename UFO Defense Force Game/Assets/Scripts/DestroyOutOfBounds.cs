using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds = -15.0f;

    private ScoreManager scoreManager; //Reference the score manager so that we can update the score

    private GameManager gameManager;
    
    private DetectCollision detectCollision;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();//Getting the component DetectCollisions
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    /*
    void Awake()
    {
        Time.timeScale = 1;
    }
    */

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
            scoreManager.DecreaseScore(detectCollision.scoreToGive); //Everytime a ship sneeks past the ower bounds deduct points
            Debug.Log("Game Over!");
            gameManager.isGameOver = true;
            //Time.timeScale = 0;
        }
    }
}
