using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    public int Score;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    public int ScoreMultiplier; 

    [SerializeField]
    public int ScoreIncrement;

    public void AddScore()
    {
        Score += ScoreIncrement * ScoreMultiplier;
        scoreText.text = "Score: " + Score.ToString();
    }
}
