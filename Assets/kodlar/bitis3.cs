using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitis3 : MonoBehaviour
{
    public GameObject kazanmatext;
    public GameObject kaybetmetext;
    public static bitis3 Instance;
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
           // bolumsecme.Seviye3 = true;
            Time.timeScale = 0f;
        }
    }
}
