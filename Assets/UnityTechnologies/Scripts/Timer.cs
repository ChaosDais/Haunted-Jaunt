using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 40.0f;
    public TextMeshProUGUI timerText;
    public GameEnding gameEnding;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft < 0f)
        {
            timeLeft = 0;
            gameEnding.OutOfTime ();
        }

        timerText.text = (timeLeft).ToString("0.00");
    }
}