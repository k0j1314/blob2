using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class initiateSimonSaysHARD : MonoBehaviour
{


    // START THE HOOK ON COLLISION WITH THE ATTACHED GAMEOBJECT
    public string simonGame2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // IF YOU COLLIDE WITH PLAYER, LOAD THE  GAME
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(simonGame2);


    }

    // Update is called once per frame
    void Update()
    {// IF YOU WON THE game, DESTROY THE ATTACHED GAMEOBJECT
        if (invincibilityFrame.HKwin == true)
        {
            Destroy(gameObject);
        }
    }
}
