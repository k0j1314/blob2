using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreKeeper2 : MonoBehaviour
{
    
    public Text scoreObj;
    public static bool gunWin = false;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerScore);

        scoreObj.text = "Score : " + ScoreKeeper.playerScore.ToString();

        if (ScoreKeeper.playerScore >= 10)
        {
            gunWin = true;
            SceneManager.LoadScene("kojiScene");
            ScoreKeeper.playerScore = 0;
        }
    }
}
