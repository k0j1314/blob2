using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initiatehookHARD : MonoBehaviour
{


    // START THE HOOK GAME ON COLLISION WITH THE ATTACHED GAMEOBJECT
    public string hookGameHard;
    // Start is called before the first frame update
    void Start()
    {

    }

    // IF YOU COLLIDE WITH PLAYER, LOAD THE HOOK GAME
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(hookGameHard);


    }

    // Update is called once per frame
    void Update()
    {// IF YOU WON THE HOOKGAME, DESTROY THE ATTACHED GAMEOBJECT
        if (invincibilityFrame.HKHARDwin == true)
        {
            Destroy(gameObject);
        }
    }
}
