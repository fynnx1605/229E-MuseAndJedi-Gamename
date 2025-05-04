using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        Vector2 moveInput;
        Rigidbody2D rb2d;
        float move;
        [SerializeField]float speed;
        [SerializeField] float jumpforce;
        /*[SerializeField] bool isJumping;*/                                //ISJUMPING//ISJUMPING
        
        [SerializeField] private GameObject Win;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
            Win.SetActive(false);
        }
        // Update is called once per frame
        void Update()
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            rb2d.AddForce(moveInput*speed);
            /*move = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(move * speed, rb2d.velocity.y);*/
            if (Input.GetButtonDown("Jump") /*&& !isJumping*/)               //ISJUMPING//ISJUMPING
            {
                rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpforce));
            }
        }
        
        /*public void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isJumping = false;
            }
        }
        private void OnCollisionExit2D(Collision2D other)                     //ISJUMPING//ISJUMPING
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isJumping = true;
            }
        }*/
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            int currentScore = ScoreManager.Instance.score;
            
            
            if (other.CompareTag("Finish"))
            {
                if (currentScore >= 500)
                {
                    Win.SetActive(true);
                    Time.timeScale = 0f; //freeze screen
                }
            }
        }

}
