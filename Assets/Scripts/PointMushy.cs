using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMushy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(100);
            Destroy(gameObject);
        }
    }
}
