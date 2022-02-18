using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    public static int score = 0;
    int remainingScore;
    public Text scoreNumber;

    void Start()
    {
        rb.velocity = transform.right * speed;

        remainingScore = score;
        score = remainingScore;
        

    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
       Enemy2 enemy = hitInfo.GetComponent<Enemy2>();
        if (enemy != null)
        {
            enemy.TakeDamage(100);
            Destroy(gameObject);
        }
    }

    void reduceScore()
    {
        remainingScore += 1;

        score = remainingScore;
       
    }
}
