using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public InputField cmdinput;
    public Text latest1;
    public Text latest2;
    public Text latest3;
    public Text latest4;
    public Text latest5;

    public void onInput()
    {
        latest5.text = latest4.text;
        latest4.text = latest3.text;
        latest3.text = latest2.text;
        latest2.text = latest1.text;
        latest1.text = cmdinput.text;
        cmdinput.text = "";
        return;
    }
}
