using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.5f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
