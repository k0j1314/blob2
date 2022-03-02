using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    // amkes an object move back and forth, at a customized speed, and customized Distance


    public float speed = 1.5f;
    float i = 0;
    bool right = true;
    float x;
    SpriteRenderer spriteRenderer;
    public float distanceLoop;
    float xPlus;


    // Start is called before the first frame update
    void Start()
    {
        // x is the leftmost position the object will go
        x = transform.position.x;

        // i will be the current position of o bject
        i = x;
        // get spritre renderer
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //xPlus is the most rightmost point the object will go
        xPlus = x + distanceLoop;

    }
    /*
    // Update is called once per frame
    IEnumerator wait()
    {

        yield return new WaitForSeconds(4);
        Debug.Log("kokokok");

    }
    IEnumerator pause()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("yayaya");

    }
    */
    void Update()
    {
        
        
        // move the fish back and forth with some if conditions
        // if moving right, move right
        if (i < xPlus && right == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            i = transform.position.x;


        }
        // if reaches xPlus, turn around left
        if (i >= xPlus && right == true)
        {
            // StartCoroutine(wait());
            i = xPlus-0.1f;
            right = false;
            spriteRenderer.flipX = true;

            
        }
        // if moving left, go left
        if (i <= xPlus && right == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

            i = transform.position.x;
           // StartCoroutine(pause());
        }
        // if at x, turn around right
        if (i <=x && right == false)
        {

          //  StartCoroutine(wait());
            right = true;
            spriteRenderer.flipX = false;
            i = x +0.1f;
        }

    }
}
