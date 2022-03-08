using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyFishMove : MonoBehaviour
{
    // amkes an object move back and forth, at a customized speed, and customized Distance


    public float speed = 1.5f;
    float i = 0;
    bool right = true;
    float y;
    SpriteRenderer spriteRenderer;
    public float distanceLoop;
    float yPlus;


    // Start is called before the first frame update
    void Start()
    {
        // x is the leftmost position the object will go
        y = transform.position.y;

        // i will be the current position of o bject
        i = y;
        // get spritre renderer
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //xPlus is the most rightmost point the object will go
        yPlus = y + distanceLoop;

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
        if (i < yPlus && right == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            i = transform.position.y;


        }
        // if reaches xPlus, turn around left
        if (i >= yPlus && right == true)
        {
            // StartCoroutine(wait());
            i = yPlus - 0.1f;
            right = false;
           // spriteRenderer.flipX = true;


        }
        // if moving left, go left
        if (i <= yPlus && right == false)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;

            i = transform.position.y;
            // StartCoroutine(pause());
        }
        // if at x, turn around right
        if (i <= y && right == false)
        {

            //  StartCoroutine(wait());
            right = true;
            //spriteRenderer.flipX = false;
            i = y + 0.1f;
        }

    }
}
