using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    GameObject anaKup;
    public int yukseklik;
    public static Toplayıcı Instance;
    void Start()
    {
        Instance = this;
        anaKup = GameObject.Find("AnaKüp");  
    }

    // Update is called once per frame
    void Update()
    {
       anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
        
    }

    public void yukseklıkazalt()
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "topla" && other.gameObject.GetComponent<toplanabilirkup>().getToplandıMı() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<toplanabilirkup>().toplandıyap();
            other.gameObject.GetComponent<toplanabilirkup>().indexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
        }
    }
}
