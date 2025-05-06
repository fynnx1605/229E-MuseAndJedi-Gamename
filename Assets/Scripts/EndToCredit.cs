using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndToCredit : MonoBehaviour
{
    [SerializeField] private GameObject win;
    public float delayTime1 = 0.1f;
    [SerializeField] private GameObject creds;
    public float delayTime2 = 2f;
    
    private bool invoked = false;
    
    void Awake()
    {
        win.SetActive(false);
        creds.SetActive(false);
    }
    void DelayWin()
    {
        int currentScore = ScoreManager.Instance.score;
        
        if (currentScore >= 500)
        {
            win.SetActive(true);
        }
    }
    void DelayCredit()
    {
            win.SetActive(false);
            creds.SetActive(true);
            Time.timeScale = 0f;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!invoked)
            {
                invoked = true;
                Invoke("DelayWin", delayTime1);
                Invoke("DelayCredit", delayTime2);
            }
        }
    }
}
