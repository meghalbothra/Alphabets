using Kakera;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeftRightUtpal : MonoBehaviour
{
    public int indexOfLeftOrRight;
    public List<string> namesList = new List<string>();
    public TMP_InputField inputName;
    public TMP_Text text;
    public bool isTeacher;
    public GameObject startMenu;

    public void joinTeacher()
    {
        isTeacher = true;
    }

    public void joinStudent()
    {
        isTeacher = false;

    }


    public void GoLeft()
    {
        if (indexOfLeftOrRight > 0)
        {
            indexOfLeftOrRight--;

            if(inputName.text != string.Empty)
            {
                namesList[indexOfLeftOrRight] = inputName.text;
                inputName.text = string.Empty;
                
            }
            text.text = namesList[indexOfLeftOrRight];


        }


        EnableOnlyOneRenderer();

    }

    public void GoRight()
    {
        if (indexOfLeftOrRight < 9)
        {
            
            if (inputName.text != string.Empty)
            {
                namesList[indexOfLeftOrRight] = inputName.text;
                inputName.text = string.Empty;
            }
              
            



            indexOfLeftOrRight++;

            text.text = namesList[indexOfLeftOrRight];

        }

        EnableOnlyOneRenderer();
       
    }


    public void EnableOnlyOneRenderer()
    {
        for(int i=0; i<10; i++)
        {
            if (i != indexOfLeftOrRight)
            {
                GameObject.Find(i.ToString()).GetComponent<MeshRenderer>().enabled = false;


            }
            else
            {
                GameObject.Find(i.ToString()).GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("PickerController").GetComponent<PickerController>().PutTheMeshRenderer(GameObject.Find(i.ToString()).GetComponent<MeshRenderer>());



            }
        }
    }


}
