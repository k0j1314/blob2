using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class invincibilityFrame : MonoBehaviour
{

    [SerializeField]
    private bool isInvincible = false;
    [SerializeField]
    private float invincibilityDurationSeconds;

    [SerializeField]
    private float invincibilityDeltaTime;

    [SerializeField]
    private GameObject model;

    public Text healthNumber; // the text image on HUD 


    static public int health = 3; // static as to preserve between scene transitions
                                  // private SpriteRenderer mySpriteRenderer;
    int healthRemaining; // an extra placeholder for the health remaining




    // Start is called before the first frame update
    void Start()
    {
        //invincibilityDurationSeconds = 1.5f;
        //invincibilityDeltaTime = 0.15f;


        // start the healthbar and also when switching back scenes, set the healthbar to latest update
        healthRemaining = health;
        // healthRemaining = int.Parse(healthNumber.text);
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();


    }

    private IEnumerator BecomeTemporarilyInvincible()
    {
        // logic goes here

        isInvincible = true;

        for (float i = 0; i < invincibilityDurationSeconds; i += invincibilityDeltaTime)
        {

            if (model.transform.localScale == Vector3.one)
            {
                ScaleModelTo(Vector3.zero);
            }
            else
            {
                ScaleModelTo(Vector3.one);
            }


            yield return new WaitForSeconds(invincibilityDurationSeconds);


        }

        isInvincible = false;

        ScaleModelTo(Vector3.one);

    }


    private void ScaleModelTo(Vector3 scale)
    {
        model.transform.localScale = scale;
    }


    void lowerHealth()
    // lowers player health by 1 and displays it on the screen
    {
        if (isInvincible == true)
            return;



        healthRemaining -= 1;
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();

        StartCoroutine(BecomeTemporarilyInvincible());


    }



    void OnCollisionEnter2D(Collision2D col)
    {
        // if i collide with an obstacle, lose health
        if (col.gameObject.CompareTag("Obstacle"))
        {
            lowerHealth();
            // Debug.Log("YARYAR");

        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
