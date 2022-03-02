using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// HOOK GAME HEALTH + INVINCIBILITY FRAMES

public class invincibilityFrame : MonoBehaviour
{

    public static bool HKwin = false;

    public static bool HKHARDwin = false;

    [SerializeField]
    private bool isInvincible = false;
    [SerializeField]
    private float invincibilityDurationSeconds;

    [SerializeField]
    private float invincibilityDeltaTime;

    [SerializeField]
    private GameObject model;

    public Text healthNumber; // the text image on HUD 


    static public int health = 3; // static as to preserve between scene transitions
                                  // private SpriteRenderer mySpriteRenderer;
    int healthRemaining; // an extra placeholder for the health remaining

    public GameObject winMsg;
    public GameObject loseMessage;

    public GameObject itemWithTimerCode;
    finalCountdown timerItem;


    // Start is called before the first frame update
    void Start()
    {
        //invincibilityDurationSeconds = 1.5f;
        //invincibilityDeltaTime = 0.15f;
        HKwin = false;

        loseMessage.SetActive(false);
        winMsg.SetActive(false);
        // start the healthbar and also when switching back scenes, set the healthbar to latest update
        healthRemaining = health;
        // healthRemaining = int.Parse(healthNumber.text);
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();


        timerItem = itemWithTimerCode.GetComponent<finalCountdown>();


    }
    // BECOME INVINCIBLE, FLASH N STUFF WHILE U ARE, VERY COOL , VERY POG
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

    // when you beat the game,  become invincible so u dont accidently lose ransdom lives, and show some funky text wahoo
    private IEnumerator permInvincible()
    {
        isInvincible = true;



        


        

        /* for (float i = 0; i < 300; i += invincibilityDeltaTime)
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
        */
        //isInvincible = false;
        winMsg.SetActive(true);
        yield return new WaitForSeconds(2);

        ScaleModelTo(Vector3.one);
        SceneManager.LoadScene("kojiScene");
    }
    // the blink effect ooooo the illusion of blinking is just scaling the pic from 1 , 0
    private void ScaleModelTo(Vector3 scale)
    {
        model.transform.localScale = scale;
    }
    // if you lose the game, show a boohoo msg, get booted out
    IEnumerator loseGame()
    {
        loseMessage.SetActive(true);
        yield return new WaitForSeconds(2);

        loseMessage.SetActive(false);
        health = 3;
        SceneManager.LoadScene("kojiScene");


    }
    // lose a hea;th
    void lowerHealth()
    // lowers player health by 1 and displays it on the screen   
    {
        if (isInvincible == true)
            return;



        healthRemaining -= 1;
        health = healthRemaining;
        healthNumber.text = healthRemaining.ToString();

        StartCoroutine(BecomeTemporarilyInvincible());


        // if you lose the game, u lose
        if (healthRemaining <= 0)
        {
            healthRemaining = 0;
            health = healthRemaining;
            healthNumber.text = healthRemaining.ToString();
            StartCoroutine(loseGame());
        }


    }


    
    void OnCollisionEnter2D(Collision2D col)
    {
        // if i collide with an obstacle, lose health
        if (col.gameObject.CompareTag("Obstacle"))
        {
            lowerHealth();
            // Debug.Log("YARYAR");

        }
    }



   
    void Update()
    {
        // if i have at least 1 life by the timer hits 0, i win wahoo!!!!!!!
        if (timerItem.timeRemaining <=0 && health> 0)
        {
            //HKwin = true;
            Debug.Log("weewoo");
            isInvincible = true;

            if (HKwin == true && HKHARDwin == false)
                HKHARDwin = true;

            if (HKwin == false)
                HKwin = true;
            health = 3;

            StartCoroutine(permInvincible());


        }

    }
}
