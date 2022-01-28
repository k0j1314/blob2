using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class InitiateGame : MonoBehaviour
{

    public string simonSays;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(simonSays);
            

    }

    // Update is called once per frame
    void Update()
    {
        if (SGameMain.SGWin == true)
        {
            Destroy(gameObject);
        }
    }
}
