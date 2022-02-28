using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    public Text healthNumber;
    static public int heart = 5;
    int healthRemaining;
    // Start is called before the first frame update
    void Start()
    {
        healthRemaining = heart;
        heart = healthRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        healthNumber.text = healthRemaining.ToString();

        if(heart == 0)
        {
            SceneManager.LoadScene("kojiScene");
        }
    }

    void lowerHealth()
    {
        healthRemaining -= 1;

        heart = healthRemaining;
        healthNumber.text = healthRemaining.ToString();
    }

    public void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            lowerHealth();
        }
    }
}
