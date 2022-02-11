using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishFacingDirection : MonoBehaviour
{

    private SpriteRenderer mySpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
          
             mySpriteRenderer.flipX = true;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
   
            mySpriteRenderer.flipX = false;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))) // up to the left
        {
            // transform.eulerAngles = new Vector3(0, 0, -10);

        }
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))) // up and right
        {
           // transform.eulerAngles = new Vector3(0, 0, 10);
        }

        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))) // down left
        {
             // transform.eulerAngles = new Vector3(0, 0, 10);

        }
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))) // down right
        {
           // transform.eulerAngles = new Vector3(0, 0, -10);

        }
    }
}
