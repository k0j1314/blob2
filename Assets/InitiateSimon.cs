using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class InitiateSimon : MonoBehaviour
{

    public string simonGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(simonGame);
            

    }

    // Update is called once per frame
    void Update()
    {
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
