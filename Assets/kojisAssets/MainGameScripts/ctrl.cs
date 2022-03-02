using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ctrl : MonoBehaviour
{
    public float speed = 1.5f;
    
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

    }

}