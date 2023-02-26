using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro namespace added to access the library for UI

public class ScoreManager : MonoBehaviour
{
    public int score; //Keep our score value

    public TextMeshProUGUI scoreText; //Visual text element to be modified

    //This function rewards the player
    public void IncreaseScore(int amount) //This method when called incrases the score by a predetermied amount set in score variable
    {
        score += amount; //Add amount to the score
        UpdateScoreText(); //Update the score UI Text
    }

    //This funciton penalizes the player
    public void DecreaseScore(int amount) //This method when called decreases the score by a predetermied amount set in score variable
    {
        score -= amount; //Subtract amount to the score
        UpdateScoreText(); //Update the score UI Text
    }

    public void UpdateScoreText() //This method updates the score in the HUD UI Text
    {
        scoreText.text = "Score: "+ score;
    }
}
