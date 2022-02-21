using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructionsPopup : MonoBehaviour
{
    public Text instructionText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showText());


    }

    IEnumerator showText()
    {
        instructionText.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        instructionText.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
