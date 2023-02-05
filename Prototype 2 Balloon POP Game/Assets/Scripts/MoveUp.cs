using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    public float upperBound = 25;

    public ScoreManager scoreManager; //stores a refereence to the scoremanager

    public Balloon balloon; //reference the balloon script to get score

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
       //make the balloon float upward

       transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

       if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); //Reduces score for allowing the ballon to leave the screen
            Destroy(gameObject); //pops the balloon
        }
    }
}
