using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText3 : MonoBehaviour
{

    //Text display;
    Text instruction;

    void Start()
    {
        instruction = GetComponent<Text>();
        //instruction.text = "Hello???????";
    }

    public void Display(string Text)
    {
        Debug.Log(Text);
        instruction.text = Text;

    }
    /*public void Display ()
    {
        
        instruction.text = "This is a TEST. Is it working? If you are seeing this message, then yes it is working.";
        

    }*/
}
