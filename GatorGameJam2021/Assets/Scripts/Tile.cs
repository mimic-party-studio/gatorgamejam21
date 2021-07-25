using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct dictionaryItem {
    public string item;
    public string result;
}

[System.Serializable]
public class Tile : MonoBehaviour
{
    [HideInInspector] public int x;
    [HideInInspector] public int y;
    public Sprite sprite;
    [TextArea(5,10)] public string text;
    public string hide; //The hide MUST match to the Tile name of the hiding spot
    public string[] moveList;
    public dictionaryItem[] useList;
    public dictionaryItem[] lookList;
    public dictionaryItem[] takeList;
    public Dictionary<string, string> use;
    public Dictionary<string, string> look;
    public Dictionary<string, string> take;

    void Awake() {
        use = new Dictionary<string, string>();
        foreach(dictionaryItem theitem in useList)
        {
            use.Add(theitem.item, theitem.result);
        }
        look = new Dictionary<string, string>();

        foreach(dictionaryItem theitem in lookList)
        {
            look.Add(theitem.item, theitem.result);
        }
        take = new Dictionary<string, string>();

        foreach(dictionaryItem theitem in takeList)
        {
            take.Add(theitem.item, theitem.result);
        }
    }
}