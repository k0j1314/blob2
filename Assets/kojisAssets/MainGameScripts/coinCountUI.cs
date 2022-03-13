using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCountUI : MonoBehaviour
{

    public Text coinCount; // refer to the ui text for coins
    public static int numCoinsCollected = 0;  // static int ot keep track of coins
    int coins = 0;   // local just to kkep num

    public Image coinImage; 

     
    // Start is called before the first frame update
    void Start()
    {
        
        coins = numCoinsCollected;
        if ( numCoinsCollected <= 0)
        { 
            coinCount.gameObject.SetActive(false);
            coinImage.gameObject.SetActive(false);
           // Debug.Log("lokiodjmaifvnwes");
        }
        if (numCoinsCollected > 0)
        {
            coinCount.gameObject.SetActive(true);
            coinImage.gameObject.SetActive(true);
        }

        coinCount.text = coins.ToString() + "/10";

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("coin"))
        {

            coinCount.gameObject.SetActive(true);
            coinImage.gameObject.SetActive(true);
            numCoinsCollected++;
            coins = numCoinsCollected;
            coinCount.text = coins.ToString() + "/10";

            Debug.Log(coins);
            Debug.Log(numCoinsCollected);
        }

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (numCoinsCollected > 0){
            coinCount.gameObject.SetActive(true);
        coinImage.gameObject.SetActive(true);
        Debug.Log("coincGALLOREE");
        }

        */
    }
}
