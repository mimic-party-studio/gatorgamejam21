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
        string [] args = cmdinput.text.Split(' ');
        cmdinput.text = "> " + cmdinput.text;
        pushUp();

        /*if(args.Length > 2)
        {
            cmdinput.text = "that's too complicated. i should use less words.";
        }
        else if(args[0].Equals("use"))
        {
            if(currenttile.use.ContainsKey(args[1]))
            {
                //change current tile
                cmdinput.text = currenttile.use[args[1]];
            }
            else cmdinput.text = "I can't use a "+ args[1]+ ".";
        }
        else if(args[0].Equals("take"))
        {
            if(currenttile.take.ContainsKey(args[1]));
        }
        else if(args[0].Equals("look"))
        {

        }
        else if(args[0].Equals("move"))
        {
            
        }
        else if(args[0].Equals("hide"))
        {
            if(currenttile.hide != null)
            {
                //go hide
            }
        }
        else
        {
            cmdinput.text = "i don't know how to "+ args[0]+".";
        }
        pushUp();*/
        return;
    }

    public void pushUp()
    {
        latest5.text = latest4.text;
        latest4.text = latest3.text;
        latest3.text = latest2.text;
        latest2.text = latest1.text;
        latest1.text = cmdinput.text;
        cmdinput.text = "";
    }
}
