using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextInput : MonoBehaviour
{
    public InputField cmdinput;
    public Text latest1;
    public Text latest2;
    public Text latest3;
    public Text latest4;
    public Text latest5;
    public Player player;
    public Sprite planter;
    public Sprite bush;
    public Sprite box;
    public Sprite trashcan;

    public void onInput()
    {
        string [] args = cmdinput.text.Split(' ');
        cmdinput.text = "> " + cmdinput.text;
        pushUp();

        if(args.Length > 2)
        {
            cmdinput.text = "that's too complicated. i should use less words.";
        }
        else if(args[0].Equals("use"))
        {
            if(player.current.use != null && player.current.use.ContainsKey(args[1]))
            {
                if(args[1] == "door") {
                    SceneManager.LoadScene(player.current.use[args[1]]);
                }
                else if(args[1] == "plant") {
                    cmdinput.text = player.current.use[args[1]];
                }
            }
            else cmdinput.text = "I can't use a "+ args[1]+".";
        }
        else if(args[0].Equals("take"))
        {
            if(player.current.take != null && player.current.take.ContainsKey(args[1]))
            {
                cmdinput.text = player.current.take[args[1]];
                player.plant = true;
            }
            else cmdinput.text = "I can't take a "+ args[1]+".";
        }
        else if(args[0].Equals("look"))
        {
            Debug.Log(args[1]);
            Debug.Log(player.current.look);
            if(player.current.look != null && player.current.look.ContainsKey(args[1]))
            {
                cmdinput.text= player.current.look[args[1]];
            }
            else cmdinput.text = "I can't look at a "+args[1]+".";
        }
        else if(args[0].Equals("move"))
        {
            if(player.current.moveList != null && System.Array.IndexOf(player.current.moveList, args[1]) > -1)
            {
                Tile newTile;
                if(args[1] == "forward") {
                    newTile = player.map[player.current.x+1, player.current.y];
                    player.changeLocation(newTile);
                }
                else if(args[1] == "left") {
                    newTile = player.map[player.current.x, player.current.y-1];
                    player.changeLocation(newTile);
                }
                else if(args[1] == "right") {
                    newTile = player.map[player.current.x, player.current.y+1];
                    player.changeLocation(newTile);
                }
                else if(args[1] == "back") {
                    player.path.Pop();
                    player.changeLocBack(player.path.Peek());
                }
                cmdinput.text = player.current.text;
            }
            else cmdinput.text = "I can't move "+ args[1]+".";
        }
        else if(args[0].Equals("hide"))
        {
            if(player.current.hide != null && player.current.hide.Equals(args[1]))
            {
                player.hidden = true;
                if(args[1] == "planter") {
                    player.hideLoc(planter);
                }
                else if(args[1] == "bush") {
                    player.hideLoc(bush);

                }
                else if(args[1] == "box") {
                    player.hideLoc(box);

                }
                else if(args[1] == "trashcan") {
                    player.hideLoc(trashcan);
                }
                
                StartCoroutine(ExampleCoroutine());

            }
        }
        else
        {
            cmdinput.text = "i don't know how to "+ args[0]+".";
        }
        pushUp();
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
    
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
