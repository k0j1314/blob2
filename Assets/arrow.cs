using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    Transform target;

    public Transform target1;

    public Transform target2;

    public Transform target3;

    public Transform target4;


    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (SGameMain.SGWin == false)
            target = target1;
        else if (SGameMain.SGWin == true && ScoreKeeper.gunWin == false && invincibilityFrame.HKwin == false)
            target = target2;

        else if (SGameMain.SGWin == true && ScoreKeeper.gunWin == true && invincibilityFrame.HKwin == false)
            target = target3;

        else if (invincibilityFrame.HKwin == true)
            target = target4;


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

    }
}
