using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// SPAWN THE FISH AT CERTAIN POINTS DEPENDING ON GAMES WON
public class SpawnOnSuccess : MonoBehaviour
{

// the spawnpoints 
    public GameObject spawnItem1; // the post- game 1 spawnpoint
    public GameObject spawnItem2;  // the post- game 2 spawnpoint
    public GameObject spawnItem3; // the post- game 3 spawnpoint
    public GameObject spawnItem4; // post game 4 spawnpoint
    public GameObject spawnItem5; // post game 4 spawnpoint
    public GameObject spawnItem6; // post game 4 spawnpoint



    // coordinatews of spawn1
    float x1;
    float y1;
    float z1;

    // coordinatews of spawn2
    float x2;
    float y2;
    float z2;

    // coordinatews of spawn3
    float x3;
    float y3;
    float z3;

    // coordinatews of spawn4
    float x4;
    float y4;
    float z4;

    // coordinatews of spawn5
    float x5;
    float y5;
    float z5;

    // coordinatews of spawn6
    float x6;
    float y6;
    float z6;

    // Start is called before the first frame update
    void Start()
    {
        // set the coordiantes
        x1 = spawnItem1.transform.position.x;
        y1 = spawnItem1.transform.position.y;
        z1 = spawnItem1.transform.position.z;


        x2 = spawnItem2.transform.position.x;
        y2 = spawnItem2.transform.position.y;
        z2 = spawnItem2.transform.position.z;

        x3 = spawnItem3.transform.position.x;
        y3 = spawnItem3.transform.position.y;
        z3 = spawnItem3.transform.position.z;

        x4 = spawnItem4.transform.position.x;
        y4 = spawnItem4.transform.position.y;
        z4 = spawnItem4.transform.position.z;

        x5 = spawnItem5.transform.position.x;
        y5 = spawnItem5.transform.position.y;
        z5 = spawnItem5.transform.position.z;

        x6 = spawnItem6.transform.position.x;
        y6 = spawnItem6.transform.position.y;
        z6 = spawnItem6.transform.position.z;


        // after beating just game 1 , spawn at game 1 if you lose game 2
        if (SGameMain.SGWin == true && ScoreKeeper.gunWin == false)
        {
            // transform.position = spawnPoint1.position;
            transform.position = new Vector3(x1- 10, y1, z1);


            //  my_fish.transform.position.y = -2.4;
            // my_fish.transform.position.x = 16.4;
        }
        
         
      //  do an if statement for apwnpooint2
         // after beating game 2, spawn here if u lose game 3
        if (ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
        {
            transform.position = new Vector3(x2 - 10, y2, z2);

        }   
         
          
        // if you beat game 3, spawn after game 3
        if (invincibilityFrame.HKwin == true && SGameMain2.SGWin2 == false)
        {
            transform.position = new Vector3(x3 - 10, y3, z3);

        }

        // if you beat game 4, spawn after game 4
        if (SGameMain2.SGWin2 == true && ScoreKeeper2.gunWin == false)
        {
            transform.position = new Vector3(x4 - 10, y4, z4);

        }
        // if you beat game 5, spawn after game 5
        if(ScoreKeeper2.gunWin == true && invincibilityFrame.HKHARDwin == false)
        {
            transform.position = new Vector3(x5 - 10, y5, z5);
        }

        if (invincibilityFrame.HKHARDwin == true)
        {
            transform.position = new Vector3(x6 - 10, y6, z6);
        }
    }

}
