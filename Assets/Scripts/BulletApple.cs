using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletApple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BulletManager.Instance.AddBullet(2);
            Destroy(gameObject);
        }

        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
    
    
    
    
}
