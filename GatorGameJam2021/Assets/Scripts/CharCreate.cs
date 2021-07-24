using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharCreate : MonoBehaviour
{
    public InputField nameinput;
    public GameObject inputscreen;
    public GameObject errorscreen;
    public GameObject nextscreen;
    public GameObject infoscreen;
    public GameObject gamescreen;
    public Text nexttext;
    public Text codetext;
    public Text infotext;
    bool infochanged = false;
    string charname = "";
    string code = "";

    // Start is called before the first frame update
    public void onInput()
    {
        if(nameinput.text.Length == 6)
        {
            charname = nameinput.text;
            charname = charname.ToLower();
            inputscreen.SetActive(false);
            nextscreen.SetActive(true);
        }
        else
        {
            charname = "karkat";
            inputscreen.SetActive(false);
            errorscreen.SetActive(true);
        }
        onNext();
        return;
    }

    public void onNext()
    {
        nexttext.text = "GREETINGS, " + charname + ".";
        for(int c = 0; c < 6; c++)
        {
            if(charname[c]>96 && charname[c]< 100)
            {
                code += "0";
            }
            else if(charname[c]>99 && charname[c]< 103)
            {
                code += "1";
            }
            else if(charname[c]>102 && charname[c]< 105)
            {
                code += "2";
            }
            else if(charname[c]>104 && charname[c]< 107)
            {
                code += "3";
            }
            else if(charname[c]>106 && charname[c]< 109)
            {
                code += "4";
            }
            else if(charname[c]>108 && charname[c]< 111)
            {
                code += "5";
            }
            else if(charname[c]>110 && charname[c]< 114)
            {
                code += "6";
            }
            else if(charname[c]>113 && charname[c]< 117)
            {
                code += "7";
            }
            else if(charname[c]>116 && charname[c]< 120)
            {
                code += "8";
            }
            else
            {
                code += "9";
            }
        }
        codetext.text = code;
        return;
    }

    public void changeInfo()
    {
        if(!infochanged)
        {
            infotext.text = "OBJECTS YOU CAN INTERRACT WITH WILL APPEAR IN <b>BOLD</b>. FOR INSTANCE:\n\n you enter a dark hallway. you can go <b>left</b> or <b>right</b>.\n\nYOU WILL NEVER NEED TO INTERACT WITH AN OBJECT THAT IS NOT BOLD.";
            infochanged = true;
        }
        else
        {
            infoscreen.SetActive(false);
            gamescreen.SetActive(true);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
