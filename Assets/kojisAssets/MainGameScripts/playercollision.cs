using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    // explode the object 

    public Animator animator;

    public GameObject myMine;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        myMine.GetComponent<BoxCollider2D>().enabled = false;
        //   animator.SetBool("explode", true);
        //  Destroy(gameObject);
        StartCoroutine(PlayAndDisappear());
        

    }

        // play and disappear after delay:
    IEnumerator PlayAndDisappear()
        {
        animator.SetBool("explode", true);
        //col.collider.enabled = false;
        yield return new WaitForSeconds(1);
            gameObject.SetActive(false); // deactivate object
        animator.SetBool("explode", false);
        //this.GetComponent<Collider>().enabled = true;
        // Destroy(gameObject);

    }
}
