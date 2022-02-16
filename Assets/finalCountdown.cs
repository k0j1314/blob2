using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class finalCountdown : MonoBehaviour
{

    cameramove begin;
    public GameObject my_camera;

    public float timeRemaining = 20;
    public bool timerIsRunning = false;
    public Text clockDown;
    public bool beginTimerCheck = false;
    //public GameObject winMessage;



    public Text healthNumber;

     public static int healthNum = 3;

    int healthRemaining; 

    // Start is called before the first frame update
    void Start()
    {
        healthRemaining = healthNum;
        healthNumber.text = healthRemaining.ToString();
        begin = my_camera.GetComponent<cameramove>();
        timerIsRunning = false;
      //  healthNum = int.Parse(healthNumber.text);
      //  healthNumber.text = healthNum.ToString();


    }



    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //float milliSeconds = (timeToDisplay % 1) * 1000;
        clockDown.text = string.Format("{0:00}", seconds);

    }




    // Update is called once per frame
    void Update()
    {
        healthNum = int.Parse(healthNumber.text);



        if (begin.startGame == true && beginTimerCheck == false)
        {
            timerIsRunning = true;
            beginTimerCheck = true;


        }



        if (timerIsRunning == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                //winMessage.SetActive(true);

                DisplayTime(0);

                timeRemaining = 21;

                timerIsRunning = false;
                
            }
            /*
            {
                Debug.Log("youre a loser");
                loseMessage.SetActive(true);
                //healthNumber.text = "3";

                StartCoroutine(waitClose());
            }
            */

        }


        

    }
}
