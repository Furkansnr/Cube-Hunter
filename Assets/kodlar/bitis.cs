using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bitis : MonoBehaviour
{
    public GameObject kazanmatext;
    public GameObject kaybetmetext;
    public static bitis Instance;
    private void Awake()
    {
        Instance = this;
        kaybetmetext.SetActive(false);
        kazanmatext.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
          oyunmenuyonet.Instance.panel.SetActive(true);
          kazanmatext.SetActive(true);
          hareket.Instance.GetComponent<hareket>().enabled = false;
          bolumsecme.seviye2 = true;
          Time.timeScale = 0f;
          Cursor.visible = true;
      }
   }
}
