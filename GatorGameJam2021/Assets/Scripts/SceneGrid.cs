using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneGrid : MonoBehaviour
{
    public Sprite[] column0;
    public Sprite[] column1;
    public Tile[,] grid;

    Tile GetTile(string name)
    {
        Tile tile = gameObject.transform.Find(name).GetComponent<Tile>();
        return tile;
    }

    // Start is called before the first frame update
    void Start()
    {
        grid = new Tile [2, 2] {
            {GetTile("Entrance"), null},
            {null,                null}
        };
        Debug.Log(grid[0,0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
