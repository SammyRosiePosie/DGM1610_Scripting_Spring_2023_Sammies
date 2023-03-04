using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneToLoad;
    
    private AudioSource startGameAudio;
    public AudioClip startGame;
   
    private AudioSource quitGameAudio;
    public AudioClip quitGame;

    // Start is called before the first frame update
    public void StartGame()
    {
        startGameAudio = GetComponent<AudioSource>();
        SceneManager.LoadScene(sceneToLoad); //Indexed Scene to Load
        Debug.Log("New Scene Loaded!");
        startGameAudio.PlayOneShot(startGame, 0.5f);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
        quitGameAudio.PlayOneShot(quitGame, 0.5f);
    }
}
