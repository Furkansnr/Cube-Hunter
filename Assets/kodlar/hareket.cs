using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    [SerializeField] private float ilerigitmehızı;
    [SerializeField] private float sagasolagıtmehızı;
    public static hareket Instance;
    public bool durdurkapa;
    public float zMin, zMax;

    private void Awake()
    {
        Cursor.visible = false;
        Instance = this;
        Time.timeScale = 1f;
    }

    private void Start()
    {
        switch (levelcontrol.level)
        {
          case 1:
              zMin = 10f;
              zMax = 18.30f;
              break;
          case 2:
              zMin = 16f;
              zMax = 25f;
              break;
          case 3:
              zMin = 23f;
              zMax = 32f;
              break;
        }
    }


    void Update()
   {
       // İleri hareket
       transform.Translate(Vector3.forward * ilerigitmehızı * Time.deltaTime);

       // Mouse pozisyonunu al
       Vector3 mousePosition = Input.mousePosition;

       // Fare pozisyonunu dünya koordinat sistemindeki hedef konumuna dönüştür
       Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));

       // Hedef pozisyonun x ve y değerlerini karakterin x ve y değerlerine eşitle
       targetPosition.x = transform.position.x;
       targetPosition.y = transform.position.y;
       targetPosition.z = Mathf.Clamp(targetPosition.z, zMin, zMax);
       // Hedef pozisyonu karakterin z eksenine atanmış hareketin etkisiyle yumuşat
       Vector3 smoothTargetPosition = Vector3.Lerp(transform.position, targetPosition, 0.5f);

       // Karakteri hedef pozisyonun z değerine yönlendir
       transform.position = smoothTargetPosition;
   }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            oyunmenuyonet.Instance.panel.SetActive(true);
            Time.timeScale = 0f;
            GetComponent<hareket>().enabled = false;
            durdurkapa = true;
        }
    }
}
