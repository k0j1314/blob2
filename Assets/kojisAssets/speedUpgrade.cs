using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class speedUpgrade : MonoBehaviour
{
    
    public GameObject my_fish;
    public GameObject fin_item;

    ctrl TheScript;
    GameObject TheGameController;


    void Start()
    {
        fin_item.GetComponent<Image>().enabled = false;

        
        TheScript = my_fish.GetComponent<ctrl>();

    }

    void Update()
    {
        if (SGameMain.SGWin==true)
        {
            fin_item.GetComponent<Image>().enabled = true;
            TheScript.speed = 30;
        }
        else
        {
            fin_item.GetComponent<Image>().enabled = false;
            TheScript.speed = 20;
        }
    }

}