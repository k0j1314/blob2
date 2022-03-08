using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public bool startGame = false;
    public float speed = .5f;

    // Start is called before the first frame update
    void Start()
    {
        //startGame = false;
      /*  if (invincibilityFrame.HKwin == false)
            speed = 20;
        else speed = 5;
      */
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 height = transform.position;
        if (transform.position.y < 55 && transform.position.y > 49 && invincibilityFrame.HKwin == false)
        {
            speed = 8;
        }
        else if (transform.position.y <= 49 && transform.position.y > 35 && invincibilityFrame.HKwin == false)
        {
            speed = 15;
        }
        else if (invincibilityFrame.HKwin == false)
        {
            speed = 20;
        }
        if (transform.position.y > 4.1) {
            startGame = false;
            height.y -= speed * Time.deltaTime;
            transform.position = height;

    }
        else if (transform.position.y <=4.1)
            startGame = true;



    }
}
