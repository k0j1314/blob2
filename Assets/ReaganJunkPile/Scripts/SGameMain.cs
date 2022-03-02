using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SGameMain : MonoBehaviour
{
    //add a button disable while simonsaying?
    public static bool SGWin;

    Color RBase = new Color(0.6f, 0.1f, 0.05f, 1);
    Color RPress = new Color(1,.078f,.078f,1);

    Color GBase = new Color(0, .4f, 0.1f, 1);
    Color GPress = new Color(0, .75f, 0.2f, 1);

    Color BBase = new Color(0, 0.1f, 0.4f, 1);
    Color BPress = new Color(0, 0.2f, 0.8f, 1);

    Color YBase = new Color(0.6f, 0.6f, 0, 1);
    Color YPress = new Color(0.8f, 0.75f, 0, 1);
    public Text tryAgain;
    public Text winText;
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
        SBRed.GetComponent<Image>().color= RPress;//highlight
        Invoke("RedClick", 0.3f);
        ifSame();
    }
    public void RedClick(){
        SBRed.GetComponent<Image>().color= RBase;
    }


     public void GreenB(){
         currButt=2;
         SBGreen.GetComponent<Image>().color= GPress; //26,202,64,1)
         Invoke("GreenClick",0.3f);
         ifSame();
    }
     public void GreenClick(){
        SBGreen.GetComponent<Image>().color= GBase;
    }
     public void BlueB(){
         currButt=3;
         SBBlue.GetComponent<Image>().color=BPress;
         Invoke("BlueClick",0.3f);
         ifSame();
    }
    public void BlueClick(){
        SBBlue.GetComponent<Image>().color= BBase;
    }
     public void YellowB(){
         currButt=4;
         SBYellow.GetComponent<Image>().color= YPress;
         Invoke("YellowClick",0.3f);
         ifSame();
    }
    public void YellowClick(){
         SBYellow.GetComponent<Image>().color= YBase;
    }

    public void DisableButtons()
    {
        SBYellow.GetComponent<Button>().enabled = false;
        SBBlue.GetComponent<Button>().enabled = false;
        SBGreen.GetComponent<Button>().enabled = false;
        SBRed.GetComponent<Button>().enabled = false;
        
    }

    public void EnableButtons()
    {
        SBYellow.GetComponent<Button>().enabled = true;
        SBBlue.GetComponent<Button>().enabled = true;
        SBGreen.GetComponent<Button>().enabled = true;
        SBRed.GetComponent<Button>().enabled = true;

    }

    public void AllBright()
    {
        SBRed.GetComponent<Image>().color = RPress;
        SBBlue.GetComponent<Image>().color = BPress;
        SBGreen.GetComponent<Image>().color = GPress;
        SBYellow.GetComponent<Image>().color = YPress;
    }
    public void AllGone()
    {
        SBRed.GetComponent<Image>().color = new Color(1,1,1,0);
        SBBlue.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        SBGreen.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        SBYellow.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        winText.enabled = true;
    }
    public void BackToScene()
    {
        SceneManager.LoadScene("kojiScene");
    }

    private void MusicOn()
    {
       // GameObject.FindGameObjectWithTag("Music").GetComponent<MusicLooper>().PlayMusic();
    }
    public void UserWrong()
    {
        tryAgain.enabled = false;
        StartCoroutine("showPattern");
    }

    public void ifSame(){
        if(currButt==simonSaying[counter]){
            counter++;
            if(rounds == counter){
                if (rounds == puzzleLength)
                {
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
          tryAgain.enabled = true;
          Invoke("UserWrong", 2.5f);
            //StartCoroutine("showPattern");
        }
    }

    public IEnumerator showPattern(){
        DisableButtons();
        yield return new WaitForSeconds(1);
        rounds++;
        for(int i=0; i<rounds; i++){
           if( simonSaying[i]==1){
                SBRed.GetComponent<Image>().color= RPress;//highlight
                yield return new WaitForSeconds(0.6f);//add f for fractions of a second (0.5f)
                SBRed.GetComponent<Image>().color= RBase;
                yield return new WaitForSeconds(0.6f);
            }
         if( simonSaying[i]==2){
                SBGreen.GetComponent<Image>().color= GPress;
                yield return new WaitForSeconds(0.6f);
                SBGreen.GetComponent<Image>().color= GBase;
                yield return new WaitForSeconds(0.6f);
            }
         if( simonSaying[i]==3){
                SBBlue.GetComponent<Image>().color= BPress;
                yield return new WaitForSeconds(0.6f);
                SBBlue.GetComponent<Image>().color= BBase;
                yield return new WaitForSeconds(0.6f);
            }
         if( simonSaying[i]==4){
                SBYellow.GetComponent<Image>().color= YPress;
                yield return new WaitForSeconds(0.6f);
                SBYellow.GetComponent<Image>().color= YBase;
                yield return new WaitForSeconds(0.6f);

            }
        }
        EnableButtons();
    }

    public void SimonWin()
    {
        Invoke("DisableButtons", 0.25f);
        Invoke("AllBright", 1.0f);
        Invoke("AllGone", 2.5f);
        SGWin = true;
       // Invoke("MusicOn", 3.25f);
        Invoke("BackToScene", 3.5f);
        

    }
    void Start(){
        simonSaying= new int[puzzleLength];
        for(int i=0; i<puzzleLength; i++){
            simonSaying[i]=Random.Range(1,5);
        }
        SGWin = false;
        tryAgain.enabled = false;
        winText.enabled = false;
       // GameObject.FindGameObjectWithTag("Music").GetComponent<MusicLooper>().StopMusic();
        StartCoroutine("showPattern");
    }


    
     
}
