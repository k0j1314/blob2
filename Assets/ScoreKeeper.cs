using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public static int playerScore = 0;
    public Text scoreObj;
    public static bool gunWin = false;

    // Update is called once per frame
    void Update()
    {
        scoreObj.text = "Score : " + playerScore.ToString();

        if(playerScore >= 10)
        {
            gunWin = true;
            SceneManager.LoadScene("kojiScene");
        }
    }
}
