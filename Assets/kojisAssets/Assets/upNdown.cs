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
    {
        speed = 1.5f;

        speed = Random.Range(3, 10);

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
            speed = Random.Range(3, 10);
        }
        else
        {
            goingUp = true;
            speed = Random.Range(3, 10);
        }


        if (transform.position.y >= 10 && goingUp == false )
            warning.SetActive(true);
        else warning.SetActive(false);

    }

}


