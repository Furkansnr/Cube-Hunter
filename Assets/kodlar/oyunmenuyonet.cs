using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunmenuyonet : MonoBehaviour
{
    public GameObject panel;
    public static oyunmenuyonet Instance;
    public int lvl2, lvl3;
    public GameObject durdurbut;
    private void Start()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void durdur()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        hareket.Instance.GetComponent<hareket>().enabled = false;
    }

    public void menudon()
    {
        SceneManager.LoadScene(0);
        
    }

    public void bolum()
    {
        SceneManager.LoadScene(1);

    }

    public void cıkıs()
    {
        Application.Quit();
    }

    public void panelkapa()
    {
        panel.SetActive(false);
        hareket.Instance.GetComponent<hareket>().enabled = true;
        Time.timeScale = 1f;
    }

    public void Update()
    {
        if (hareket.Instance.durdurkapa == true)
        {
           durdurbut.SetActive(false);
        }  
    }
}
