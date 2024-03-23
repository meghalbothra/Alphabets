using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareStrings : MonoBehaviour
{

    [SerializeField] GameObject Sr;
    [SerializeField] GameObject tick;
    [SerializeField] GameObject obj;
    [SerializeField] GameObject gameManager;
    public bool utpal = false;
    
   
    void Update()
    {


      /*  if (utpal == true)
        {
            gameManager.GetComponent<GameManager>().StartGame();
            utpal = false;
        }*/
        /*string a = "This is an apple";
        string b = "ThIs is An Apple";
        if (a.ToLower() == b.ToLower()) Debug.Log("fffffff");*/

        if (Sr.GetComponent<SpeechRecognizer>().GetTheFirstStringUtpal() == null) return;
        if (GetComponent<EnterTextUtpal>().GiveString() == null) return;

        if (Sr.GetComponent<SpeechRecognizer>().GetTheFirstStringUtpal().ToLower() == GetComponent<EnterTextUtpal>().GiveString().ToLower())
        {
            tick.GetComponent<Image>().enabled = true;

            if(utpal == false)
            {
                gameManager.GetComponent<GameManager>().StartGame();
                utpal = true;
            }
            

        }
        else
        {
            tick.GetComponent<Image>().enabled = false;
            gameManager.GetComponent<GameManager>().StopGame();

        }

        

    }



}
