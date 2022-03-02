using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneUp : MonoBehaviour
{
    // GET A LIFE WHEN YOU COLLIDE WITH ATTQACHED OBJECT



    //static  bool  array of collected status
    public static bool[] healthCollectedArray = new bool[] { false, false, false };

    int i;

    // Start is called before the first frame update
    void Start()
    { // see coincollected
        //int i takes the name of the item (which i named specifically different numbers as to point to different values of the array)
        // DONT CHANGE THE NAME OF THE OBJECTS
        i = int.Parse(this.gameObject.name);

        // if not collected, spawn
        if (!healthCollectedArray[i])
            gameObject.SetActive(true);
        // if already collected, dont spawn
        if (healthCollectedArray[i])
            gameObject.SetActive(false);

    }
    void OnCollisionEnter2D(Collision2D col)
    {// on collision, gain 1 health, despawn item
        if (col.gameObject.CompareTag("Player"))
        {
            fishHealth.health++;

            healthCollectedArray[i] = true;
            gameObject.SetActive(false);


        }
    }
}
