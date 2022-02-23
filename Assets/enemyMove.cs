using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

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
        x = transform.position.x;
        i = x;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        xPlus = x + distanceLoop;

    }

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

    void Update()
    {
        
        


        if (i < xPlus && right == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            i = transform.position.x;


        }
        if (i >= xPlus && right == true)
        {
            // StartCoroutine(wait());
            i = xPlus-0.1f;
            right = false;
            spriteRenderer.flipX = true;

            
        }
        if (i <= xPlus && right == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

            i = transform.position.x;
           // StartCoroutine(pause());
        }
        if (i <=x && right == false)
        {

          //  StartCoroutine(wait());
            right = true;
            spriteRenderer.flipX = false;
            i = x +0.1f;
        }

    }
}
