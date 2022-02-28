using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    private void OnCollisionEnter2D(Collision2D cold)
    {
        if(cold.collider.tag == ("Enemy"))
        {
            
            Physics2D.IgnoreCollision(cold.collider, cold.otherCollider);
        }

        if(cold.collider.tag == ("Walls") || cold.collider.tag == ("Player"))
        {
            Destroy(gameObject);
        }
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
