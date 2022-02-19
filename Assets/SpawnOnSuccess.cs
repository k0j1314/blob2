using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SpawnOnSuccess : MonoBehaviour
{

    //public GameObject my_fish;

    // var SpawnPoint1 : Transform;
    public GameObject spawnItem1;
    public GameObject spawnItem2;
    public GameObject spawnItem3;

    float x1;
    float y1;
    float z1;

    float x2;
    float y2;
    float z2;

    float x3;
    float y3;
    float z3;
    // Start is called before the first frame update
    void Start()
    {
        x1 = spawnItem1.transform.position.x;
        y1 = spawnItem1.transform.position.y;
        z1 = spawnItem1.transform.position.z;


        x2 = spawnItem2.transform.position.x;
        y2 = spawnItem2.transform.position.y;
        z2 = spawnItem2.transform.position.z;

        x3 = spawnItem3.transform.position.x;
        y3 = spawnItem3.transform.position.y;
        z3 = spawnItem3.transform.position.z;


        if (SGameMain.SGWin == true && invincibilityFrame.HKwin == false)
        {
            // transform.position = spawnPoint1.position;
            transform.position = new Vector3(x1- 10, y1, z1);


            //  my_fish.transform.position.y = -2.4;
            // my_fish.transform.position.x = 16.4;
        }
        /*
         
        do an if statement for apwnpooint2
         
         
         
         
         
          */

        if (invincibilityFrame.HKwin == true)
        {
            transform.position = new Vector3(x3 - 10, y3, z3);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
