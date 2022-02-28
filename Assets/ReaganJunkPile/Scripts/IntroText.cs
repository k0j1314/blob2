using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject iText;
    public float scroll = 0.75f;
    void Start()
    {
        //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicLooper>().PlayMusic();
    }
    public float timeRemaining = 10;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * scroll * Time.deltaTime;
        timeRemaining = timeRemaining - Time.deltaTime;
        if (timeRemaining <0)
        {
            print("done");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
