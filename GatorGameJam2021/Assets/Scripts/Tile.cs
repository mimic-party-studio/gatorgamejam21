using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Tile : MonoBehaviour
{
    public Sprite sprite;
    [TextArea(5,10)]
    public string text;
}