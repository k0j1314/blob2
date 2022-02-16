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


    public Text speedText;

    bool textShown;
    
    void Start()
    {
        speedText.gameObject.SetActive(false);

        textShown = false;

        fin_item.GetComponent<Image>().enabled = false;

        
        TheScript = my_fish.GetComponent<ctrl>();

    }
    
    IEnumerator showText()
    {
        speedText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);
        speedText.gameObject.SetActive(false);
        textShown = true;


    }
    

    void Update()
    {
        if (SGameMain.SGWin==true)
        {
            fin_item.GetComponent<Image>().enabled = true;
            TheScript.speed = 30;

            if (textShown == false)
                StartCoroutine(showText());



        }
        else
        {
            fin_item.GetComponent<Image>().enabled = false;
            TheScript.speed = 20;
        }
    }

}