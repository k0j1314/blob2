using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightChanges : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        Vector3 p = transform.position;

        if (SGameMain.SGWin == true && ScoreKeeper.gunWin == false && invincibilityFrame.HKwin == false)
        {
            p.y = 60;

            gameObject.transform.position = p;
        }

        
         
         if (SGameMain.SGWin == true && ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
        {
            p.y = 90;

            gameObject.transform.position = p;
        }



        



        if (/*SGameMain.SGWin == true && ScoreKeeper.gunWin == true && */ invincibilityFrame.HKwin == true)
        {
            p.y = 180;

            gameObject.transform.position = p;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
