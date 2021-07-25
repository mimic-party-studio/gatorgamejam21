using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ALB1 : MonoBehaviour
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
        if(tilename == "01" && !firstscene)
        {
            currentint = "01-1";
            firstscene = true;
            chatFeeder();
        }
        else if(tilename == "04" && !secondscene)
        {
            currentint = "02-1";
            secondscene = true;
            chatFeeder();
        }
        return;
    }

    public void chatFeeder()
    {
        switch(currentint)
        {
            case "01-1": 
                fctext.text = "go to hell, al.";
                firstchoiceint = "01-2";
                sctext.text = "how do i get into the SAC?";
                secondchoiceint = "01-3";
                mydialogue.text = "";
                aldialogue.text = "HOW CAN I HELP YOU TODAY?";
                break;
            case "01-2":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "";
                aldialogue.text = "UNDERSTOOD.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "01-3":
                fctext.text = "great. real helpful, al.";
                firstchoiceint = "01-4";
                sctext.text = "when will they be back?";
                secondchoiceint = "01-5";
                mydialogue.text = "how do i get into the SAC?";
                aldialogue.text = "only SAC employees can enter.";
                break;
            case "01-4":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "";
                aldialogue.text = "I AM HAPPY TO HELP.";
                mydialogue.text = "great. real helpful, al.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "01-5":
                fctext.text = "ugh. okay.";
                sctext.text = "that sucks.";
                mydialogue.text = "";
                aldialogue.text = "MONDAY AT 8:00AM.";
                mydialogue.text = "when will they be back?";
                firstchoiceint = "01-6";
                secondchoiceint = "01-7";
                break;
            case "01-6":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "";
                aldialogue.text = "OKAY.";
                mydialogue.text = "ugh. okay.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "01-7":
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "";
                aldialogue.text = "I AM SORRY.";
                mydialogue.text = "that sucks.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "02-1": 
                fctext.text = "did i ask?";
                sctext.text = "that's not very long.";
                aldialogue.text = "DID YOU KNOW: THIS OFFICE IS OVER 1 YEARS OLD?";
                mydialogue.text = "";
                firstchoiceint = "02-2";
                secondchoiceint = "02-3";
                break;
            case "02-2": 
                fctext.text = "that's what i thought.";
                sctext.text = "so... 1 year old?, huh?";
                mydialogue.text = "did i ask?";
                aldialogue.text = "YOU DID NOT.";
                firstchoiceint = "02-4";
                secondchoiceint = "02-5";
                break;
            case "02-3": 
                fctext.text = "great.";
                sctext.text = "what's the 0.1%?";
                mydialogue.text = "that's not very long.";
                aldialogue.text = "YES. AND IT IS ALREADY 99.9% EFFICIENT.";
                firstchoiceint = "02-6";
                secondchoiceint = "02-7";
                break;
            case "02-4": 
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "that's what i thought.";
                aldialogue.text = "YES YOU DID.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "02-5": 
                fctext.text = "great.";
                sctext.text = "what's the 0.1%";
                mydialogue.text = "so... 1 year old?, huh?";
                aldialogue.text = "YES. AND IT IS ALREADY 99.9% EFFICIENT.";
                firstchoiceint = "02-6";
                secondchoiceint = "02-7";
                break;
            case "02-6": 
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "great.";
                aldialogue.text = "I AM GLAD YOU THINK SO.";
                firstchoiceint = "NONE";
                secondchoiceint = "NONE";
                break;
            case "02-7": 
                fctext.text = "";
                sctext.text = "";
                mydialogue.text = "what's the 0.1%?";
                aldialogue.text = "I HAVE AN IDEA.";
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
