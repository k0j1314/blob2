using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fishHealth : MonoBehaviour
{

    public Text healthNumber; // the text image on HUD 
    public GameObject my_fish;   // this object
    public GameObject heightIndicator;  // the height indicator bar
    static public int health = 3; // static as to preserve between scene transitions
                                  // private SpriteRenderer mySpriteRenderer;
    public GameObject damageScreen; // the red damage screen
    int healthRemaining; // an extra placeholder for the health remaining


    public Text heightWarning;


    [SerializeField]
    private bool isInvincible = false;
    [SerializeField]
    private float invincibilityDurationSeconds;

    [SerializeField]
    private float invincibilityDeltaTime;

    [SerializeField]
    private GameObject model;




    // Start is called before the first frame update
    void Start()
    {
        // start the healthbar and also when switching back scenes, set the healthbar to latest update
        healthRemaining = health;
        // healthRemaining = int.Parse(healthNumber.text);
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();
        

        // mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // turn invincible for certain number of seconds, while flashing as to show it

    private IEnumerator BecomeTemporarilyInvincible()
    {
        

        isInvincible = true;

        for (float i = 0; i < invincibilityDurationSeconds; i += invincibilityDeltaTime)
        {

            if (model.transform.localScale == Vector3.one)
            {
                ScaleModelTo(Vector3.zero);
            }
            else
            {
                ScaleModelTo(Vector3.one);
            }


            yield return new WaitForSeconds(invincibilityDurationSeconds);


        }

        isInvincible = false;

        ScaleModelTo(Vector3.one);

    }

    private void ScaleModelTo(Vector3 scale)
    {
        model.transform.localScale = scale;
    }




    void tooHigh()
    // make the screen flash red if fish is too high
    {
        var color = damageScreen.GetComponent<Image>().color;
        color.a += 0.5f;
        damageScreen.GetComponent<Image>().color = color;


    }

    void resetValues()
        // resets all the static values so that u can play the game again!
    {
        health = 3;
        speedUpgrade.game1Win = 0;
        speedUpgrade.game2Win = 0;
        speedUpgrade.game3win = 0;
        speedUpgrade.game6win = 0;
        speedUpgrade.game5win = 0;
        speedUpgrade.difPass = 0;
    invincibilityFrame.HKwin = false;

        SGameMain.SGWin = false;
        ScoreKeeper.gunWin = false;
        ScoreKeeper.playerScore = 0;
        SGameMain2.SGWin2 = false;
        ScoreKeeper2.gunWin = false;
        invincibilityFrame.HKHARDwin = false;
       


        coinCountUI.numCoinsCollected = 0;

        coinCollected.collectedArray = new bool[] { false, false, false, false, false, false, false, false, false, false };
        oneUp.healthCollectedArray = new bool[] { false, false, false };

    }

    void lowerHealth()
    // lowers player health by 1 and displays it on the screen
    {

        if (isInvincible == true)
            return;

        healthRemaining -= 1;

        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();

        StartCoroutine(BecomeTemporarilyInvincible());

        if (healthRemaining <= 0)
        {
            die();

        }

    }
    void die()
    // kills the player
    {
        // Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;  // for testing purposes
        // WHEN DYING, RESET ALL THE STATIC VARIABLES
        SceneManager.LoadScene("GameOver");

        resetValues();

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        // if i collide with an obstacle, lose health
        if (col.gameObject.CompareTag("Obstacle"))
        {
            lowerHealth();
            //  StartCoroutine("wait");

        }
       /* if (col.gameObject.CompareTag("Undefined"))
        {
            col.gameObject.SetActive(false);
            Debug.Log("kdjnsvbjhkvb");

        }
       */
        
    }


    void Update()
    {
        // always keep track of health
        healthRemaining = health;
        healthNumber.text = healthRemaining.ToString();



        // 
        Vector3 p = transform.position; // 
        float height = heightIndicator.transform.position.y; // i had to do this to grab the y value of the heighindicator

        // if fish is too high flash the screen red
        if (my_fish.transform.position.y > height && damageScreen.GetComponent<Image>().color.a <= 0)
        {
            tooHigh();
            heightWarning.gameObject.SetActive(true);
        }   

        if (my_fish.transform.position.y <= height)
            heightWarning.gameObject.SetActive(false);



        // if the fish ignore the hieght warning, die
        if (my_fish.transform.position.y > height + 20)
            die();

        // bottom border 
        if (p.y < -75f)
        {
            p.y = -75f;
            transform.position = p;
        }



        // if the damage screen goes off , this takes the screen back dowon
        if (damageScreen.GetComponent<Image>().color.a > 0)
        {
            var color = damageScreen.GetComponent<Image>().color;
            color.a -= 0.003f;
            damageScreen.GetComponent<Image>().color = color;
        }

        if (my_fish.transform.position.y >= 338 && invincibilityFrame.HKwin == true)
        {
            // IF YOU BEAT THE GAME, RESET ALL THE STATIC VARIABLES
            // i know i should have this as a single method, but ur stuck with this, deal with it
            // exactly the same as the thing from  die() earlier
            SceneManager.LoadScene("Win Screen");

            resetValues();
            /*
             * health = 3;
            speedUpgrade.game1Win = 0;
            speedUpgrade.game2Win = 0;
            speedUpgrade.game3win = 0;

            invincibilityFrame.HKwin = false;

            SGameMain.SGWin = false;
            ScoreKeeper.gunWin = false;
            ScoreKeeper.playerScore = 0;

            invincibilityFrame.HKHARDwin = false;

            SGameMain2.SGWin2 = false;

            coinCountUI.numCoinsCollected = 0;

            coinCollected.collectedArray = new bool[] { false, false, false, false, false, false, false, false, false, false} ;

            oneUp.healthCollectedArray = new bool[] { false, false, false };
            */


        }


        if (my_fish.transform.position.y >= 337 && coinCountUI.numCoinsCollected >=10)
        {
            SceneManager.LoadScene("Win Screen2");

            resetValues();
        }




    }


}
