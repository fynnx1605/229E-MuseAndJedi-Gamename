using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [SerializeField] TMP_Text scoreText;


    public int score = 0;
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void AddPoint()
    {
        score += 100;
    }*/
    
    
    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score : " + score;
    }

    
}
