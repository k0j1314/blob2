using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;


    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    void OnTriggerEnter2D (Collider2D hitInfo)
    {
       Enemy2 enemy = hitInfo.GetComponent<Enemy2>();
        if (enemy != null)
        {
            enemy.TakeDamage(100);
            ScoreKeeper.playerScore += 1;
            Destroy(gameObject);
        }
    }
}
