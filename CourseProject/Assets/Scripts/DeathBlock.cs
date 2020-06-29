using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBlock : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelMusic;
    public GameObject levelTimer;
    public GameObject fadeOut;
    public GameObject levelBlocker;

    void Death()
    {
        if (GlobalTimer.extendScore == 0)
        {
            StartCoroutine(YouFellOff());
        }
    }

    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        youFell.SetActive(true);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
