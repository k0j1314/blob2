using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightChanges : MonoBehaviour
{
    // CHANGES THE MAX HEIGHT YOU CAN GO BASED ON GAMES WON

    // Start is called before the first frame update
    void Start()
    {

        Vector3 p = transform.position;
        // if u start
        if (SGameMain.SGWin == false/* && ScoreKeeper.gunWin == false/* && invincibilityFrame.HKwin == false*/)
        {
            p.y = 20;

            gameObject.transform.position = p;
        }

        
         // if you beat game 1
         if (SGameMain.SGWin == true &&  ScoreKeeper.gunWin == false &&  invincibilityFrame.HKwin == false)
        {
            p.y = 80;

            gameObject.transform.position = p;
        }

         // if u beat game 2
        if (SGameMain.SGWin == true && ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
        {
            p.y = 140;

            gameObject.transform.position = p;
        }


        //
        // if you beat game 3
        if (/*SGameMain.SGWin == true && ScoreKeeper.gunWin == true && */ invincibilityFrame.HKwin == true)
        {
            p.y = 220; //338 is the highest limit , -45 is the lowest limit

            gameObject.transform.position = p;
        }

        // beat game 4
        if (/*SGameMain.SGWin == true && ScoreKeeper.gunWin == true &&  invincibilityFrame.HKwin == true && */ SGameMain2.SGWin2 == true && ScoreKeeper2.gunWin == false)
        {
            p.y = 270; //338 is the highest limit , -45 is the lowest limit

            gameObject.transform.position = p;
        }
        // beat game 5
        if ( ScoreKeeper2.gunWin == true && invincibilityFrame.HKHARDwin== false)

            p.y = 340; //338 is the highest limit , -45 is the lowest limit

        gameObject.transform.position = p;


        // beat game 6
        if (invincibilityFrame.HKHARDwin == true)
        {
            p.y = 500; //338 is the highest limit , -45 is the lowest limit

            gameObject.transform.position = p;
        }
    }
}
/*SURFACEEEE  340
 * 
 * -----------270
 * 
 * -------------220
 * 
 * ----------140
 * 
 * -----------  80
 * 
 * ----------- 20
 * 
 * -------------  -45
 * */