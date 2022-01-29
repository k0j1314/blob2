using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fishHealth : MonoBehaviour
{

    public Text healthNumber;
    public GameObject my_fish;
    public GameObject heightIndicator;
    static int health = 3;

    public GameObject damageScreen;
    int healthRemaining ;

    
    // Start is called before the first frame update
    void Start()
    {
        healthRemaining = health;
       // healthRemaining = int.Parse(healthNumber.text);
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();

    }

    // Update is called once per frame
    void tooHigh()
    // make the screen flash red if fish is too high
    {
        var color = damageScreen.GetComponent<Image>().color;
        color.a += 0.5f;
        damageScreen.GetComponent<Image>().color = color;


    }
    void lowerHealth()
    // lowers player health by 1 and displays it on the screen
    {
        healthRemaining -= 1;
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();
        // TODO: save the value when changing scenes so that  it doesnt go back to 3 after a game


        if (healthRemaining <= 0)
        {
            die();

        }

    }
    void die()
    // kills the player
    {
        // Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;  // for testing purposes


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
            lowerHealth();

    }


    void Update()
    {
        // 
        Vector3 p = transform.position;
        float height = heightIndicator.transform.position.y;



        //if (my_fish.transform.position.x > 3)
        //  lowerHealth();

        if (my_fish.transform.position.y > height  && damageScreen.GetComponent<Image>().color.a <= 0)
            tooHigh();

        if (my_fish.transform.position.y > height + 20)
            die();


        if (p.y < -75f)
        {
            p.y = -75f;
            transform.position = p;
        }




        if (damageScreen.GetComponent<Image>().color.a > 0)
        {
            var color = damageScreen.GetComponent<Image>().color;
            color.a -= 0.001f;
            damageScreen.GetComponent<Image>().color = color;
        }

    }


}
