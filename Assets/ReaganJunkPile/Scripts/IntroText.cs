using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    // Start is called before the first frame update
    public float scroll = 0.75f;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * scroll * Time.deltaTime;
    }
}
