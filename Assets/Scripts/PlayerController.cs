using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.5f;
    public float rotationSpeed = 1.0f;
    
    
    void Update()
    {
        if(!PlayerManager.levelStarted) return; 
        if(PlayerManager.gameOver) return; 

        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Touchscreen.current != null)
        {
            Vector2 delta = Touchscreen.current.primaryTouch.delta.ReadValue();
            transform.Rotate(0, 0, delta.x * rotationSpeed);
        }
    }
}
