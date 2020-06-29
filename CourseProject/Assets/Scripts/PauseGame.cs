using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePause = false;
    public AudioSource levelMusic;
    public AudioSource pauseMusic;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePause == false)
            {
                pauseMusic.Play();
                Time.timeScale = 0;
                gamePause = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePause = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePause = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        gamePause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}



