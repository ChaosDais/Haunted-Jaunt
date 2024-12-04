using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60.0f;
    public TextMeshProUGUI timerText;
    // public GameEnding m_EndGame;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = (timeLeft).ToString("0.00");
        if (timeLeft < 0)
        {
            // Game Over
            // m_EndGame.EndGame();
        }
    }
}
