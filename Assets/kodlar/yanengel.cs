using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yanengel : MonoBehaviour
{
    public float speed;
    public int zMin, zMax;
    void Update()
    {
        transform.position =
            new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * speed, zMax - zMin) + zMin);
  
    }
    
}
