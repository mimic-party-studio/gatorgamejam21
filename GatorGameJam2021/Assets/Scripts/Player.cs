using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public struct locationUI {
        public Image image;
        public Text text;
    }

    public string name;
    public bool plant;
    public int progress;
    public int id;
    public Stack<Tile> path;
    public bool hidden;

    public Tile[,] map;
    locationUI location;
    public Tile current;

     public void changeLocation(Tile tile)
    {
        Debug.Log(tile);
        path.Push(tile);
        current = path.Peek();
        //Debug.Log(location.image.sprite);
        location.image.sprite = tile.sprite;         
        //Debug.Log(location.image.sprite);   
        //location.text.text = tile.text;
    }

    public void changeLocBack(Tile tile)
    {
        current= path.Peek();
        location.image.sprite = tile.sprite;
    }

    public void hideLoc(Sprite sprite)
    {
        location.image.sprite = sprite;
    }


    public void OnEnable()
    {
        path = new Stack<Tile>();
        map = GameObject.Find("SceneGrid").GetComponent<SceneGrid>().grid;
        GameObject temp = GameObject.Find("GameScreen");
        location.image = temp.transform.Find("LocationImage").GetComponent<Image>();
        //location.text = temp.transform.Find("Text").GetComponent<Text>();
        path.Push(map[0,0]);
        current = map[0,0];
    }

    void Update()
    {
        //Press space to change the Sprite of the Image
       /* if (Input.GetKeyDown(KeyCode.W))
        {
            changeLocation(map[current.x-1, current.y]);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            changeLocation(map[current.x+1, current.y]);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            changeLocation(map[current.x, current.y-1]);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            changeLocation(map[current.x, current.y+1]);
        }*/


    }

}
