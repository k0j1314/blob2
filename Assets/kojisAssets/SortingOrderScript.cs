using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SortingOrderScript : MonoBehaviour
{
    
    public GameObject my_fish;
    public GameObject fin_item;

    ctrl TheScript;
    GameObject TheGameController;


    void Start()
    {
        fin_item.GetComponent<Image>().enabled = false;

        TheGameController = GameObject.Find("blobfish");
        TheScript = TheGameController.GetComponent<ctrl>();

    }

    void Update()
    {
        if (SGameMain.SGWin==true)
        {
            fin_item.GetComponent<Image>().enabled = true;
            TheScript.speed = 40;
        }
        else
        {
            fin_item.GetComponent<Image>().enabled = false;
            TheScript.speed = 20;
        }
    }

}