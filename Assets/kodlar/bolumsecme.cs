using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bolumsecme : MonoBehaviour
{
    public Button geridonbut, lvl1but, lvl2but, lvl3but;
    public static bolumsecme Instance;
    public static bool seviye2,Seviye3;
    
    void Start()
    {
        Instance = this;
        if (seviye2 == true)
        {
            lvl2but.interactable = true;
        }

        if (Seviye3 == true)
        {
            lvl3but.interactable = true;
            Debug.Log("lvl3acık");
        } 
    }
    

    public void geridon()
    {
        SceneManager.LoadScene(0);
    }

    public void lvl1gec()
    {
        levelcontrol.level = 1;
        SceneManager.LoadScene(2);
    }

    public void lvl2gec()
    {
        levelcontrol.level = 2;
        SceneManager.LoadScene(3);
    }

    public void lvl3gec()
    {
        levelcontrol.level = 3;
        SceneManager.LoadScene(4);
    }
    
}
