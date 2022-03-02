using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class initiateGun : MonoBehaviour
{
    // START THE GUN GAME ON COLLISION WITH THE ATTACHED GAMEOBJECT
    public string gunGame;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    // on collision go to gun minigame
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(gunGame);


    }

    // Update is called once per frame
    void Update()
    {


        
        // if you won the minigun game, destroy the attached object ( you already won the game, y play it again? )
       if ( ScoreKeeper.gunWin == true)
              Destroy(gameObject);



    }
}
