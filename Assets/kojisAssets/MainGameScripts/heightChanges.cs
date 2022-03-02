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
        // if u beat game 1
        if (SGameMain.SGWin == true && ScoreKeeper.gunWin == false && invincibilityFrame.HKwin == false)
        {
            p.y = 60;

            gameObject.transform.position = p;
        }

        
         // if you beat game 2
         if (/*SGameMain.SGWin == true && */ ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
        {
            p.y = 90;

            gameObject.transform.position = p;
        }



        


         // if you beat game 3
        if (/*SGameMain.SGWin == true && ScoreKeeper.gunWin == true && */ invincibilityFrame.HKwin == true)
        {
            p.y = 180;

            gameObject.transform.position = p;
        }


    }
}
