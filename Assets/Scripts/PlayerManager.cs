using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool levelStarted;
    public static bool gameOver;
    public GameObject startMenuPanel;
    public GameObject gameOverPanel;

    public static int gems;
    public TextMeshProUGUI gemsText;

    public static int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        gameOver = levelStarted = false;
        Time.timeScale = 1.0f;
        gems = 0;
        score = 0;
        //PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        gemsText.text = (PlayerPrefs.GetInt("TotalGems", 0) + gems).ToString();
        scoreText.text = "Score: " + score.ToString();  

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
            PlayerPrefs.SetInt("TotalGems", PlayerPrefs.GetInt("TotalGems", 0) + gems);

            if (score > PlayerPrefs.GetInt("HighScore",0))
            {
                highScoreText.text = "HighScore" + score;

                PlayerPrefs.SetInt("HighScore: ",score);
            }

            this.enabled = false;
        }
    }
}
