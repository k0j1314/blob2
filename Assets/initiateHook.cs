using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class initiateHook : MonoBehaviour
{
    public string hookGame;
    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(hookGame);


    }

    // Update is called once per frame
    void Update()
    {
        if (invincibilityFrame.HKwin == true)
        {
            Destroy(gameObject);
        }
    }
}
