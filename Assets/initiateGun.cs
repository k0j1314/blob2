using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class initiateGun : MonoBehaviour
{

    public string gunGame;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(gunGame);


    }

    // Update is called once per frame
    void Update()
    {


        

       if ( ScoreKeeper.gunWin == true)
              Destroy(gameObject);



    }
}
