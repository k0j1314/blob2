using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInstruction : MonoBehaviour
{
    cameramove begin;
    public GameObject my_camera;
    public GameObject instructions;
    public bool instructionsShown;

    // Start is called before the first frame update
    void Start()
    {

        begin = my_camera.GetComponent<cameramove>();
        instructions.SetActive(false); // deactivate object
        instructionsShown = false;

    }

    IEnumerator waitTime()
    {

        instructions.SetActive(true); // activate object

        instructionsShown = true;

        yield return new WaitForSeconds(2);

        instructions.SetActive(false); // activate object


        //Debug.Log("FEWFWEFWEF");


    }
    // Update is called once per frame
    void Update()
    {
        if (begin.startGame == true && instructionsShown == false)
        {
            StartCoroutine(waitTime());

        }

        if (begin.startGame == false)
        {
            instructions.SetActive(false); // deactivate object
            //Debug.Log("NONONONO");
        }
    }
}
