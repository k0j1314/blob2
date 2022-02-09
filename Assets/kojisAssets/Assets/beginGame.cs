using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class beginGame : MonoBehaviour
{
    cameramove begin;
    public GameObject my_camera;
    public GameObject hook;

    // Start is called before the first frame update
    void Start()
    {
        begin = my_camera.GetComponent<cameramove>();
        hook.SetActive(false); // deactivate object

    }

    // Update is called once per frame
    void Update()
    {
        

        if (begin.startGame == true)
        {
            hook.SetActive(true); // activate object
            Debug.Log("FEWFWEFWEF");
        }

        if(begin.startGame == false)
        {
            hook.SetActive(false); // deactivate object
            Debug.Log("NONONONO");
        }


    }
}
