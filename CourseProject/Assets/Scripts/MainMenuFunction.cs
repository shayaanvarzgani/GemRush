using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public int bestEasy;
    public GameObject bestEasyDisplay; 
    public int bestHard;
    public GameObject bestHardDisplay;

    void Start()
    {
        bestEasy = PlayerPrefs.GetInt("LevelScore");
        bestEasyDisplay.GetComponent<Text>().text = "Best Easy: " + bestEasy;
        bestHard = PlayerPrefs.GetInt("LevelScoreHard");
        bestHardDisplay.GetComponent<Text>().text = "Best Hard: " + bestHard;
        Cursor.visible = true;
    }

    public void EasyGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void HardGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 8;
        SceneManager.LoadScene(2);
    }

    public void BackButton()
    {
        buttonPress.Play();
        SceneManager.LoadScene(1);
    }

    public void ViewCredits()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
