using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public static bool levelStarted;
    public static bool gameOver;
    public GameObject startMenuPanel;
    public GameObject gameOverPanel;
    

    void Start()
    {
        gameOver = levelStarted = false;
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        Touchscreen ts = Touchscreen.current;
        if (ts != null && ts.primaryTouch.press.isPressed && !levelStarted)
        { 
            levelStarted = true;
            startMenuPanel.SetActive(false);
        } 

        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
