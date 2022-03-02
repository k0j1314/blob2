using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinCollected : MonoBehaviour
{
    
    // MAKE A STATIC ARRAY OF BOOLEANS TO KEEP TRACK OF WHICH COINS HAVE BEEN COLLECTED ( needs to be static so that info saves between scene changes)
    // IF ANY CHANGES TO THIS ARE MADE, YOU MUST ALSO go change the die and wingame script of fishhealth.cs ( to reset all the values when the game ends via death or win)
    public static bool[] collectedArray = new bool[] { false, false, false, false, false, false, false, false, false, false} ;
    // deeznuts

    // if the coin has already been collected, dont spawn


    // audio source to play when u collect coin
    AudioSource audioData;
    // Start is called before the first frame update

    int i;


    void Start()
    {
        // int i takes the name of the item (which i named specifically different numbers as to point to different values of the array)
        i = int.Parse(this.gameObject.name);
       //  Debug.Log(i); // testing
        //Debug.Log("NASHBFEUYFBCDASHUKB");  testing
        audioData = GetComponent<AudioSource>();   // getaudiosource


        // if the coin has already been collected, dont "spawn" ( spawn is just turning the gameobject active or not) it
        if (!collectedArray[i-1])
        gameObject.SetActive(true);
        // if it hasnt, then do spawn it
        if (collectedArray[i - 1])
            gameObject.SetActive(false);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // when colliding with a player , play the audio, despawn the coin, and then change its array value to true ( coin has been collected)
        if (col.gameObject.CompareTag("Player"))
        {
            audioData.Play(0);

            Debug.Log("harhar");
            //Debug.Log(i);

            collectedArray[i-1] = true;

            gameObject.SetActive(false);


        }
    }
    
}
