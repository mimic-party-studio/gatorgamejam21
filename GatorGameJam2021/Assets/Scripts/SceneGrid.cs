using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if(SceneManager.GetActiveScene().name == "first_area") {
            
            grid = new Tile[3, 3] {
                {GetTile("Entrance"), GetTile("SAC Hall 1"), null},
                {GetTile("SAC Door"), GetTile("SAC Hall 2"), GetTile("Exit")},
                {null, GetTile("SAC Desk"),null},
            };
            for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if(grid[i, j] != null) {
                    grid[i, j].x = i;
                    grid[i, j].y = j;
                }
            }
        } 
        }
        if(SceneManager.GetActiveScene().name == "second_area") {
            grid = new Tile[7, 2] {
                {GetTile("Entrance/Exit"), null},
                {GetTile("Hallway 1"), null},
                {GetTile("Hallway 2"), GetTile("Hallway 3")},
                {GetTile("Room Entrance"), null},
                {GetTile("Room 1"), null},
                {GetTile("Room 2"), null},
                {GetTile("Computer"), null},
            };
            for (int i = 0; i < 7; i++) {
            for (int j = 0; j < 2; j++) {
                if(grid[i, j] != null) {
                    grid[i, j].x = i;
                    grid[i, j].y = j;
                }
            }
        } 
        }
        if(SceneManager.GetActiveScene().name == "outside_area") {
            grid = new Tile[10, 3] {
                {GetTile("Entrance"), GetTile("Outside of SAC"), null},
                {GetTile("Dead End 1"), GetTile("Open Area"), null},
                {GetTile("Grassy Sidepath 1"), GetTile("Crossroads"), null},
                {GetTile("Grassy Sidepath 2"), GetTile("Street 1"), null},
                {GetTile(null), GetTile("Street 2"), null},
                {GetTile("Plant Path 1"), GetTile("Street 3"), null},
                {GetTile("Plant Path 2"), GetTile("Street 4"), null},
                {GetTile("Grassy Sidepath 2"), GetTile("Crossroads 2"), GetTile("Stairs Path")},
                {GetTile("Vending Path"), null,  GetTile("Stairs Path 2")},
                {GetTile("Vending Path 2"), null, null}
            };
            for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 3; j++) {
                if(grid[i, j] != null) {
                    grid[i, j].x = i;
                    grid[i, j].y = j;
                }
            }
        } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
