using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int health = 100;

    public Rigidbody2D enemy;

    public float moveSpeed = 20.0f; 

    public bool changeDirection = false;

    public GameObject deathEffect;

    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveEnemy();
    }

    public void moveEnemy()
    {
            enemy.velocity = new Vector2(-1,0)*moveSpeed;
    }

    
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
