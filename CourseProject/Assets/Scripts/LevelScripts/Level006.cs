using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level006 : MonoBehaviour
{
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        RedirectToLevel.redirectToLevel = 9;
        RedirectToLevel.nextLevel = 10;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

}
