using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AILab : MonoBehaviour
{
    public bool firstscene = false;
    public bool secondscene = false;
    public Button firstchoice;
    public Button secondchoice;
    public Text fctext;
    public Text sctext;
    public Text aldialogue;
    public Text mydialogue;
    public string currentint = "";
    private string firstchoiceint = "NONE";
    private string secondchoiceint = "NONE";

    public void onUpdate(string tilename)
    {
        if(tilename == "Entrance-Exit" && !firstscene)
        {
            currentint = "01-1";
            firstscene = true;
            chatFeeder();
        }
        return;
    }

    public void chatFeeder()
    {
        switch(currentint)
        {
            case "01-1": 
                fctext.text = "why is it so cold in here?";
                firstchoiceint = "01-2";
                sctext.text = "you can't just make me one? i had an appointment";
                secondchoiceint = "01-3";
                mydialogue.text = "so, super admin?";
                aldialogue.text = "THE SUPER ADMIN HAS ACCESS TO ALL BUILDINGS ON CAMPUS.";
                break;
            case "01-2":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "why is it so cold in here?";
                aldialogue.text = "ONLY HUMANS FEEL COLD.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "01-3":
                fctext.text = "ugh";
                sctext.text = "ugh";
                mydialogue.text = "you can't just make me one? i had an appointment.";
                aldialogue.text = "YOU ARE NOT AUTHORIZED.";
                firstchoiceint = "01-4";
                secondchoiceint = "01-4";
                break;
            case "01-4":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "";
                aldialogue.text = "THANK YOU FOR YOUR PATRONAGE.";
                mydialogue.text = "ugh.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            default: aldialogue.text = "error feeding chat at "+currentint; break;
        }
        return;
    }

    public void pressFirst()
    {
        if(firstchoiceint == "NONE")
            return;
        currentint = firstchoiceint;
        chatFeeder();
        return;
    }

    public void pressSecond()
    {
        if(secondchoiceint == "NONE")
            return;
        currentint = secondchoiceint;
        chatFeeder();
        return;
    }
    
}
