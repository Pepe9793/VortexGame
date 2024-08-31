using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public static bool levelStarted;
    public GameObject startMenuPanel;

    void Start()
    {
        levelStarted = false;
    }

    void Update()
    {
        Touchscreen ts = Touchscreen.current;
        if (ts != null && ts.primaryTouch.press.isPressed && !levelStarted)
        {
            levelStarted = true;
            startMenuPanel.SetActive(false);
        } 
    }
}
