using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("kojiScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
