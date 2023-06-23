using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject planet;
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.RotateAround(planet.transform.position,Vector3.up,speed*Time.deltaTime);
    }
}
