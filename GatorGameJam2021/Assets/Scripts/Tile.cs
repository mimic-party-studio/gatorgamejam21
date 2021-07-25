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
    Dictionary<string, string> use;
    Dictionary<string, string> look;
    Dictionary<string, string> take;

    void Awake() {
        if(useList == null) {
            foreach(dictionaryItem theitem in useList)
            {
                use[theitem.item] = theitem.result;
            }

        }
        if(lookList == null) {
            foreach(dictionaryItem theitem in lookList)
            {
                look[theitem.item] = theitem.result;
            }
        }
        if(takeList == null) {
            foreach(dictionaryItem theitem in takeList)
            {
                take[theitem.item] = theitem.result;
            }
        }
    }
}