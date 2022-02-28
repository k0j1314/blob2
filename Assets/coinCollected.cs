using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinCollected : MonoBehaviour
{
    

    public static bool[] collectedArray = new bool[] { false, false, false, false, false, false, false, false, false, false} ;
    // deeznuts

    // if the coin has already been collected, dont spawn



    AudioSource audioData;
    // Start is called before the first frame update

    int i;


    void Start()
    {

        i = int.Parse(this.gameObject.name);
        Debug.Log(i);
        Debug.Log("NASHBFEUYFBCDASHUKB");
        audioData = GetComponent<AudioSource>();



        if (!collectedArray[i-1])
        gameObject.SetActive(true);

        if (collectedArray[i - 1])
            gameObject.SetActive(false);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            audioData.Play(0);

            Debug.Log("harhar");
            //Debug.Log(i);

            collectedArray[i-1] = true;

            gameObject.SetActive(false);


        }
    }
    // Update is called once per frame
    void Update()
    {
        



        if (fishHealth.health <= 0)
        {
            

            collectedArray[i - 1] = false;
            gameObject.SetActive(true);
        }
    }
}
