using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateZ : MonoBehaviour
{
    // ROTATE THE ATTACHED OBJECT certain degrees Y

    // Use this for initialization
    public float speedY = 1;
    public float speedZ = 1;
    public float RotAngleY = 45;
    public float RotAngleZ = 45;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // it rotates the thing, once again this was somethign the google gods said worked, so :) 
        float rY = Mathf.SmoothStep(0, RotAngleY, Mathf.PingPong(Time.time * speedY, 1));
        float rZ = Mathf.SmoothStep(-15, RotAngleZ, Mathf.PingPong(Time.time * speedZ, 1));
        transform.rotation = Quaternion.Euler(0, rY, rZ);
    }
}
