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
        if(SceneManager.GetActiveScene().name == "game_UI") {

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
        if (SceneManager.GetActiveScene().name == "game_UI_TWO")
        {

            grid = new Tile[5, 3] {
                {GetTile("Exit"), null, null},
                {GetTile("SAC Hall 2"), GetTile("SAC Hall 1"),null},
                {GetTile("SAC Desk"), GetTile("Entrance"), null },
                {null, GetTile("SAC Door"),null, },
                {null, GetTile("SAC Secret"),null, },
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] != null)
                    {
                        grid[i, j].x = i;
                        grid[i, j].y = j;
                    }
                }
            }
        }
        if(SceneManager.GetActiveScene().name == "UI_second") {
            grid = new Tile[7, 2] {
                {GetTile("Entrance-Exit"), null},
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
        if(SceneManager.GetActiveScene().name == "UI_outside") {
            grid = new Tile[10, 3] {
                {GetTile("Entrance"), GetTile("Outside of SAC"), null},
                {GetTile("Dead End 1"), GetTile("Open Area"), null},
                {GetTile("Grassy Sidepath 1"), GetTile("Crossroads"), null},
                {GetTile("Grassy Sidepath 2"), GetTile("Street 1"), null},
                {null, GetTile("Street 2"), null},
                {GetTile("Plant Path 1"), GetTile("Street 3"), null},
                {GetTile("Plant Path 2"), GetTile("Street 4"), null},
                {GetTile("Vending Path"), GetTile("Crossroads 2"), GetTile("Stairs Path")},
                {GetTile("Vending Path 2"), null,  GetTile("Stairs Path 2")},
                {GetTile("Exit"), null, null}
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
        //Player temp = GameObject.Find("GameScreen").GetComponent<Player>();
        //temp.path.Push(grid[0,0]);
        //temp.current = temp.path.Peek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
