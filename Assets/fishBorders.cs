using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishBorders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;

        if (p.y < -75f)
        {
            p.y = -75f;
            transform.position = p;
        }
    }
}
