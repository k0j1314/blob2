using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SGameMain : MonoBehaviour
{
    //add a button disable while simonsaying?
    public bool SGWin;

    //list of buttons   
    public GameObject SBRed; // 1
    public GameObject SBGreen; // 2
    public GameObject SBBlue; // 3
    public GameObject SBYellow; //4

    public int counter=0;
    private int currButt;
    public int rounds;
  
    public int puzzleLength;

    public int[] simonSaying;

    public void RedB(){
        currButt=1;
        SBRed.GetComponent<Image>().color= new Color(.97f,.078f,.078f,1);//highlight
        Invoke("RedClick", 0.5f);
        ifSame();
    }
    public void RedClick(){
        SBRed.GetComponent<Image>().color= new Color(0.6f,0,0,1);
    }

     public void GreenB(){
         currButt=2;
         SBGreen.GetComponent<Image>().color= new Color(.11f,.79f,.25f,1); //26,202,64,1)
         Invoke("GreenClick",0.5f);
         ifSame();
    }
     public void GreenClick(){
        SBGreen.GetComponent<Image>().color= new Color(.03f,.47f,.13f,1);
    }
     public void BlueB(){
         currButt=3;
         SBBlue.GetComponent<Image>().color= new Color(.13f,.27f,.819f,1);
         Invoke("BlueClick",0.5f);
         ifSame();
    }
    public void BlueClick(){
        SBBlue.GetComponent<Image>().color= new Color(.02f,.11f,.44f,1);
    }
     public void YellowB(){
         currButt=4;
         SBYellow.GetComponent<Image>().color= new Color(.86f,.89f,.11f,1);
         Invoke("YellowClick",0.5f);
         ifSame();
    }
    public void YellowClick(){
         SBYellow.GetComponent<Image>().color= new Color(.71f,.69f,.17f,1);
    }

    public void DisableButtons()
    {
        SBYellow.GetComponent<Button>().enabled = false;
        SBBlue.GetComponent<Button>().enabled = false;
        SBGreen.GetComponent<Button>().enabled = false;
        SBRed.GetComponent<Button>().enabled = false;
        SBRed.GetComponent<Image>().color = new Color(1, 1, 1, 0);//highlight
        SBBlue.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        SBGreen.GetComponent<Image>().color = new Color(1, 1, 1, 0); //26,202,64,1)
        SBYellow.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    public void ifSame(){
        if(currButt==simonSaying[counter]){
            counter++;
            if(rounds == counter){
                if (rounds == puzzleLength)
                {
                    print("you win!");
                    SimonWin();
                }
                else{
                    counter = 0;
                    StartCoroutine("showPattern");
                }
                
                
            }
        }
        else{
          for(int i=0; i<puzzleLength; i++){
            simonSaying[i]=Random.Range(1,5);
          }
          counter=0;
          rounds=0;
          StartCoroutine("showPattern");
        }
    }

    public IEnumerator showPattern(){
        yield return new WaitForSeconds(1);
        rounds++;
        for(int i=0; i<rounds; i++){
           if( simonSaying[i]==1){
               print("running");
                SBRed.GetComponent<Image>().color= new Color(.97f,.078f,.078f,1);//highlight
                yield return new WaitForSeconds(0.5f);//add f for fractions of a second (0.5f)
                SBRed.GetComponent<Image>().color= new Color(0.6f,0,0,1);
           }
         if( simonSaying[i]==2){
                SBGreen.GetComponent<Image>().color= new Color(.11f,.79f,.25f,1);
                yield return new WaitForSeconds(0.5f);
                SBGreen.GetComponent<Image>().color= new Color(.03f,.47f,.13f,1);
           }
         if( simonSaying[i]==3){
                SBBlue.GetComponent<Image>().color= new Color(.13f,.27f,.819f,1);
                yield return new WaitForSeconds(0.5f);
                SBBlue.GetComponent<Image>().color= new Color(.02f,.11f,.44f,1);
           }
         if( simonSaying[i]==4){
                SBYellow.GetComponent<Image>().color= new Color(.86f,.89f,.11f,1);
                yield return new WaitForSeconds(0.5f);
                SBYellow.GetComponent<Image>().color= new Color(.71f,.69f,.17f,1);
                
           }
        }
    }

    public void SimonWin()
    {
        Invoke("DisableButtons", 0.5f);
        SGWin = true;

    }
    void Start(){
        simonSaying= new int[puzzleLength];
        for(int i=0; i<puzzleLength; i++){
            simonSaying[i]=Random.Range(1,5);
        }
        SGWin = false;
        StartCoroutine("showPattern");
    }


    
     
}
