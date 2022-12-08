using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject TitleBack;

    void Start()
    {
        GameOver.SetActive(false);
        TitleBack.SetActive(false);
        StartCoroutine("GameOverAppear");
    }

    IEnumerator GameOverAppear()
    {
        yield return new WaitForSeconds(0.5f);
        GameOver.SetActive(true);
        StartCoroutine("BackAppear");
    }

    IEnumerator BackAppear()
    {
        yield return new WaitForSeconds(1.0f);
        TitleBack.SetActive(true);
    }

    
}