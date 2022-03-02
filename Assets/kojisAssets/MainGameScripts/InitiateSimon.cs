using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class InitiateSimon : MonoBehaviour
{
    // START THE SIMONSAYS GAME ON COLLISION WITH THE ATTACHED GAMEOBJECT
    public string simonGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // ON COLLISION WITH PLAYER, LOAD THE SIMONSAYS GAME
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(simonGame);
            

    }

    // Update is called once per frame
    void Update()
    {// IF YOU BEAT SIMONSAYS, DESTROY THE ATTACHED OBJECT
       if (SGameMain.SGWin == true)
        {
            Destroy(gameObject);
        }

       /*

        // if ( GUN GAME == TRUE)
       Destroy(gameObject);
        */

    }
}
