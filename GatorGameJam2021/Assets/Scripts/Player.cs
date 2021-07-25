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

    Tile[,] map;
    locationUI location;
    public Tile current;

    void changeLocation(Tile tile)
    {
        path.Push(tile);
        current = path.Peek();
        Debug.Log(location.image.sprite);
        location.image.sprite = tile.sprite;            
        //location.text.text = tile.text;
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        path = new Stack<Tile>();
        map = GameObject.Find("SceneGrid").GetComponent<SceneGrid>().grid;
        GameObject temp = GameObject.Find("Canvas");
        location.image = temp.transform.Find("Image").GetComponent<Image>();
        //location.text = temp.transform.Find("Text").GetComponent<Text>();
        path.Push(map[0,0]);
        current = path.Peek();
    }

    void Update()
    {
        //Press space to change the Sprite of the Image
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            changeLocation(map[current.x-1, current.y]);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            changeLocation(map[current.x+1, current.y]);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            changeLocation(map[current.x, current.y-1]);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            changeLocation(map[current.x, current.y+1]);
        }


    }

}
