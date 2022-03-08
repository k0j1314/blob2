using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class speedUpgrade : MonoBehaviour
{
    // CANVAS CHANGES ON MAIN MAP


    public GameObject my_fish;
    public GameObject fin_item;
    public static int game1Win = 0;
    public static int game2Win = 0;
    public static int game3win = 0;
    public static int game6win = 0;
    public static int game4win = 0;

    ctrl TheScript;
    GameObject TheGameController;


    public Text speedText;// text after beating game 1

    public Text reachTheSurface; // text after beating game 6

    public Text killedDivers;  // text after game 2

    public Text avoidedHooks;

    public Text bigBrain; // text after beating game 4

    bool textShown;

    bool text6shown;

    bool text2shown;

    bool text3shown;

    bool text4shown;


    void Start()
    {
        // all text is turned off at the start

        speedText.gameObject.SetActive(false);
        reachTheSurface.gameObject.SetActive(false);
        killedDivers.gameObject.SetActive(false);
        bigBrain.gameObject.SetActive(false);
        avoidedHooks.gameObject.SetActive(false);


        textShown = false;
        text2shown = false;
        text3shown = false;
        text6shown = false;
        text4shown = false;


        fin_item.GetComponent<Image>().enabled = false;

        
        TheScript = my_fish.GetComponent<ctrl>();

    }
    
    IEnumerator showgame1Text()
    {
        // show game 1 win text
        game1Win = 1;
        speedText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);
        speedText.gameObject.SetActive(false);
        textShown = true;


    }

    IEnumerator showgame2Text()
    {
        // show game2 win text
        game2Win = 1;
        killedDivers.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        killedDivers.gameObject.SetActive(false);

        text2shown = true;

    }

    IEnumerator showgame3Text()
    {
        // show game3 win text
        game3win = 1;
        avoidedHooks.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        avoidedHooks.gameObject.SetActive(false);

        text3shown = true;

    }




    IEnumerator showgame6Text()
    {
        // show game6 win text
        game6win = 1;
        reachTheSurface.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        reachTheSurface.gameObject.SetActive(false);

        text6shown = true;

    }

    IEnumerator showgame4Text()
    {
        // show game 1 win text
        game4win = 1;
        bigBrain.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);
        bigBrain.gameObject.SetActive(false);
        text4shown = true;


    }

    void Update()
    {
        // if you win the first game, spped boost! and text 1
        if (SGameMain.SGWin==true && invincibilityFrame.HKwin == false)
        {
            //fin_item.GetComponent<Image>().enabled = true;
            TheScript.speed = 25;

            if (textShown == false && game1Win == 0)
                StartCoroutine(showgame1Text());

        


        }
        if (invincibilityFrame.HKwin == true)
        {
            TheScript.speed = 30;

        }
        else
        {
            // 
            fin_item.GetComponent<Image>().enabled = false;
            TheScript.speed = 20;
        }

        if (invincibilityFrame.HKHARDwin == true && game6win == 0 && text6shown == false)
        {

            StartCoroutine(showgame6Text());
        }

        if (ScoreKeeper.gunWin == true && game2Win == 0 && text2shown == false)
        {

            StartCoroutine(showgame2Text());
        }
        if( invincibilityFrame.HKwin == true && game3win == 0 && text3shown == false)
        {
            StartCoroutine(showgame3Text());
        }

        if (SGameMain2.SGWin2 == true && game4win == 0 && text4shown == false)
        {
            StartCoroutine(showgame4Text());
        }
    }

}