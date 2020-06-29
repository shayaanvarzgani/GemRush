using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishHard : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject levelBlocker;
    public GameObject fadeOff;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore + " x 100";
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total: " + totalScored;
        PlayerPrefs.SetInt("LevelScoreHard", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOff.SetActive(true);
        yield return new WaitForSeconds(2);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
