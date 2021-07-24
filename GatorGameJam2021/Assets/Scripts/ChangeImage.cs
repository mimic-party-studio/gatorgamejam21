using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public int xCoordinate;
    public int yCoordinate;

    Image image;
    Sprite currSprite;

    void Start()
    {
        //Fetch the Image from the GameObject
        image = GetComponent<Image>();
    }

    void Update()
    {
        //Press space to change the Sprite of the Image
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currSprite = GameObject.Find("SceneGrid").GetComponent<SceneGrid>().grid[0,0].sprite;            
            image.sprite = currSprite;
        }
    }
}