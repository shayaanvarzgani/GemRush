using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject youFell;
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;

    

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;
        if (extendScore == 0)
        {
            StartCoroutine(YouFellOff());
        }
        else if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }

    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        yield return new WaitForSeconds(2);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
