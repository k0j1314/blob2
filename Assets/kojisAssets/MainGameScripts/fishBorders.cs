using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishBorders : MonoBehaviour
{
    void Update()
    {
        // max depth the fix can go is p , ummm i dont need this anymore as i figured out that i can turn gravity off on rigidbodies ahahahaha
        Vector3 p = transform.position;

        if (p.y < -75f)
        {
            p.y = -75f;
            transform.position = p;
        }
    }
}
