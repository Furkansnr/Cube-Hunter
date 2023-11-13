using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuyonet : MonoBehaviour
{
    public GameObject panel;
    public Text volumeAmount;
    public void SetAudio(float value)
    {
        AudioListener.volume = value;
        volumeAmount.text = ((int) (value * 100)).ToString();
    }

    private void Awake()
    {
        panel.SetActive(false);
    }

    public void oynabut()
    {
        SceneManager.LoadScene(1);
    }

    public void ayarlarbut()
    {
      panel.SetActive(true);  
    }

    public void cıkısbut()
    {
        Application.Quit();
    }

    public void ayardancık()
    {
      panel.SetActive(false);  
    }
}

