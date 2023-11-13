using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toplanabilirkup : MonoBehaviour
{
    bool toplandıMi;
    int İndex;
    public Toplayıcı toplayıcı;
    public Text text;

    void Start()
    {
        toplandıMi = false;
    }
    
    void Update()
    {

        if (toplandıMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -İndex, 0);
            }   
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel" && toplayıcı.yukseklik > 0 )
        {
            transform.parent = null;
          GetComponent<BoxCollider>().enabled = false;
          other.gameObject.GetComponent<BoxCollider>().enabled = false;
          StartCoroutine(yukseklıkazalt());
          //toplayıcı.yukseklıkazalt();
        }
        
    }

    public IEnumerator yukseklıkazalt()
    {
       Debug.Log("calıstı");
        yield return new WaitForSeconds(0.1f);
        toplayıcı.yukseklıkazalt();
    }
    public bool getToplandıMı()
    {
        return toplandıMi;
    }

    public void toplandıyap()
    {
        toplandıMi = true;
    }

    public void indexAyarla(int index)
    {
        this.İndex = index;
    }

    
}
