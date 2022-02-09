using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthbar : MonoBehaviour
{

    public Text healthNumber; // the text image on HUD 
    public GameObject my_fish;   // this object

    static public int health = 3; // static as to preserve between scene transitions
                                  // private SpriteRenderer mySpriteRenderer;
    int healthRemaining; // an extra placeholder for the health remaining


    // Start is called before the first frame update
    void Start()
    {
        // start the healthbar and also when switching back scenes, set the healthbar to latest update
        healthRemaining = health;
        // healthRemaining = int.Parse(healthNumber.text);
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();

    }

    void lowerHealth()
    // lowers player health by 1 and displays it on the screen
    {

        healthRemaining -= 1;

        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        // if i collide with an obstacle, lose health
        if (col.gameObject.CompareTag("Obstacle"))
        {
            lowerHealth();
            //  StartCoroutine("wait");

        }

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
