using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class speedUpgrade : MonoBehaviour
{
    
    public GameObject my_fish;
    public GameObject fin_item;
    public static int game1Win = 0;
    public static int game3win = 0;
    ctrl TheScript;
    GameObject TheGameController;


    public Text speedText;

    public Text reachTheSurface;

    bool textShown;

    bool text3shown;

    
    void Start()
    {
        speedText.gameObject.SetActive(false);
        reachTheSurface.gameObject.SetActive(false);

        textShown = false;
        text3shown = false;

        fin_item.GetComponent<Image>().enabled = false;

        
        TheScript = my_fish.GetComponent<ctrl>();

    }
    
    IEnumerator showgame1Text()
    {
        game1Win = 1;
        speedText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);
        speedText.gameObject.SetActive(false);
        textShown = true;


    }

    IEnumerator showgame3Text()
    {
        game3win = 1;
        reachTheSurface.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        reachTheSurface.gameObject.SetActive(false);

        text3shown = true;

    }
    

    void Update()
    {
        if (SGameMain.SGWin==true)
        {
            fin_item.GetComponent<Image>().enabled = true;
            TheScript.speed = 30;

            if (textShown == false && game1Win == 0)
                StartCoroutine(showgame1Text());



        }
        else
        {
            fin_item.GetComponent<Image>().enabled = false;
            TheScript.speed = 20;
        }

        if (invincibilityFrame.HKwin == true && game3win == 0)
        {

            StartCoroutine(showgame3Text());
        }
    }

}