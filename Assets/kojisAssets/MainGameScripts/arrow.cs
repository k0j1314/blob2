using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // THIS IS A SCRIPT THAT MAKES AN ARROW AROUND OBJECT TO POINT AT OTHER THINGS
    Transform target;
    // list out all "target" pointers

    public Transform target1; // points to simonsSays1

    public Transform target2; // points to miniGun1

    public Transform target3;// points to hookGame1

    public Transform target4; // points to simonsSays HARD MODE

    public Transform target5; // points to miniGun HARD MODE

    public Transform target6;// points to hookGame HARD

    public Transform target7; // point to the sky to complete the game!


    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {    // if you havent completed game1, it points to game1 
        if (SGameMain.SGWin == false)
            target = target1;
        // if you completed game1 but NOT game2, point to game2
        else if (SGameMain.SGWin == true && ScoreKeeper.gunWin == false && invincibilityFrame.HKwin == false)
            target = target2;
        // point to game3 if game2 is complete
        else if (SGameMain.SGWin == true && ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
            target = target3;
        // if game3 is done, point to the sky!
        else if (invincibilityFrame.HKwin == true)
            target = target7;


    }

    // Update is called once per frame
    void Update()
    {
        // the actual update on arrow pointing, i dont quite know what it does, but google says it works so here it is
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

    }
}
