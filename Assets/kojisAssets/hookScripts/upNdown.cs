using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class upNdown : MonoBehaviour
{
    public GameObject hook;

    public GameObject warning;

    float speed;

    bool goingUp = true;


    public void Start()
    {/////////////////////////////////////////////////////////////////////////////////   for testing purposes
      //  invincibilityFrame.HKwin = true;
        ////////////////////////////////////////////////////////////////////////////////
        speed = 1.5f;
        if( invincibilityFrame.HKwin == false)
            speed = Random.Range(3, 10);
        else
            speed = Random.Range(8, 15);

    }


    public void Update()
    {
        if (transform.position.y > 0 && goingUp == false)
            transform.position += Vector3.down * speed * Time.deltaTime;
        else if (transform.position.y < 20 && goingUp ==true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (transform.position.y >= 20)
        {
            goingUp = false;
            if (invincibilityFrame.HKwin == false)
                speed = Random.Range(3, 10);
            else
                speed = Random.Range(8, 15);
        }
        else
        {
            goingUp = true;
            if (invincibilityFrame.HKwin == false)
                speed = Random.Range(3, 10);
            else
                speed = Random.Range(8, 15);
        }

        if (invincibilityFrame.HKwin == false)
        {
            if (transform.position.y >= 10 && goingUp == false)
                warning.SetActive(true);
            else warning.SetActive(false);
        }
        else
        {
            if (transform.position.y >= 10 && transform.position.y <= 13 && goingUp == false)
                warning.SetActive(true);
            else warning.SetActive(false);
        }
    }

}


