using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthLoss : MonoBehaviour
{

    public Text healthNumber;
    public GameObject my_fish;

    public GameObject damageScreen;
    int healthRemaining;


    // Start is called before the first frame update
    void Start()
    {
       healthRemaining = int.Parse(healthNumber.text);

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
        healthRemaining-= 1;
        healthNumber.text = healthRemaining.ToString();

        if (healthRemaining <= 0)
        {
            die();

        }

    }
    void die()
        // kills the player
    {
        // Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;

    }


    void Update()
    {
        // 
        if (my_fish.transform.position.x > 3)
            lowerHealth();

        if (my_fish.transform.position.y > 10 && damageScreen.GetComponent<Image>().color.a <= 0)
            tooHigh();

        if (damageScreen.GetComponent<Image>().color.a > 0)
        {
            var color = damageScreen.GetComponent<Image>().color;
            color.a -= 0.001f;
            damageScreen.GetComponent<Image>().color = color;
        }

    }


}
