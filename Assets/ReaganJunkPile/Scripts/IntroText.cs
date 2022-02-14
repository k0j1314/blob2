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
    }
    public float timeRemaining = 10;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * scroll * Time.deltaTime;
        
    }
}
