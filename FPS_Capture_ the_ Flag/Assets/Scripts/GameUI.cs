using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [Header("HUD")]
    public TextMeshProUGUI pickUpText;
        
    [Header("Pause Menu")]
    public GameObject pauseMenu;

    [Header ("End Game Screen")]
    public GameObject endGameScreen;
    public TextMeshProUGUI endGameHeaderText;
    public TextMeshProUGUI endGamePickUpText;

    //Instance/Singleton
    public static GameUI instance;

    void Awake()
    {
        //Set instance to this script
        instance = this;
    }

    public void UpdatePickUpText(int score)
    {
        pickUpText.text = "PickUp: " + score;
    }

    public void TogglePauseMenu(bool paused)
    {
        pauseMenu.SetActive(paused);
    }

    public void SetEndGameScreen(bool won, int score)
    {
        endGameScreen.SetActive(true);
        endGameHeaderText.text = won == true ? "You Win" : "You Lose";
        endGameHeaderText.color = won == true ? Color.green : Color.red;
        endGamePickUpText.text = "<b>Score</b>\n" + score;
    }

    public void OnResumeButton()
    {
        GameManager.instance.TogglePauseGame();
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene("Level_0");
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
