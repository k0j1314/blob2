using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
