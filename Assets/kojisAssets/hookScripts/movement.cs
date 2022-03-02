using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set WASD and arrow key movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))


        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            

        }


        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
           

        }

        Vector3 upBound = transform.position; // 
        Vector3 lowBound = transform.position; // 

        if (upBound.y >= 8.2f)
        {
            upBound.y = 8.2f;
            transform.position = upBound;
        }

        if (lowBound.y <= -0.3f)
        {
            lowBound.y = -0.3f;
            transform.position = lowBound;
        }



    }
}
