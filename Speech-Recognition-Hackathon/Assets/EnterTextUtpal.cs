using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnterTextUtpal : MonoBehaviour
{
    public LeftRightUtpal LeftRightUtpal;
    private string input = null;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        input = s;
        input = GameObject.Find("InputFieldUtpal").GetComponent<TMP_InputField>().text;
        
        Debug.Log(input);
        
    }

    public string GiveString()
    {
        //return input;
        return LeftRightUtpal.text.text;
    }

}
