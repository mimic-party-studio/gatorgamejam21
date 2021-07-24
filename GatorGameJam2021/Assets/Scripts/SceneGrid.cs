using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneGrid : MonoBehaviour
{
    public Sprite[] column0;
    public Sprite[] column1;
    public Tile[,] grid;
    const int xMax = 2;
    const int yMax = 2;

    Tile GetTile(string name)
    {
        Tile tile = gameObject.transform.Find(name).GetComponent<Tile>();
        return tile;
    }

    // Start is called before the first frame update
    void Start()
    {
        grid = new Tile[xMax, yMax] {
            {GetTile("Entrance"), GetTile("2")},
            {GetTile("3"),        GetTile("4")}
        };
        for (int i = 0; i < xMax; i++) {
            for (int j = 0; j < yMax; j++) {
                if(grid[i, j] != null) {
                    grid[i, j].x = i;
                    grid[i, j].y = j;
                }
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
