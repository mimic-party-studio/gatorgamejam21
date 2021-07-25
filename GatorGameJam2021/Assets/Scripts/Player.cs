using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    AudioSource audioPlayer;
    public AudioClip monsterSound;
    public AudioClip transitionSound;
    public AudioClip deathSound;
    Sprite tempSprite;
    public Sprite deathSprite;
    public Monster monster;
    Coroutine currRoutine;

     public void changeLocation(Tile tile)
    {
        Debug.Log(tile);
        path.Push(tile);
        current = path.Peek();
        //Debug.Log(location.image.sprite);
        location.image.sprite = tile.sprite;  
        audioPlayer.Play();     
        //Debug.Log(location.image.sprite);   
        //location.text.text = tile.text;
        monster.aggressionIndex += 1;
    }

    public void changeLocBack(Tile tile)
    {
        current= path.Peek();
        location.image.sprite = tile.sprite;
        audioPlayer.Play();     

    }

    public void hideLoc(Sprite sprite1, Sprite sprite2)
    {
        tempSprite = location.image.sprite;
        currRoutine = StartCoroutine(HideScreen(sprite1, sprite2));
    }

    public void die()
    {
        StartCoroutine(DeathScreen(deathSprite));
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
        audioPlayer = gameObject.GetComponent<AudioSource>();
    }

    IEnumerator HideScreen(Sprite sprite1, Sprite sprite2)
    {
        location.image.sprite = sprite1;
        yield return new WaitForSeconds(2);
        location.image.sprite = sprite2;
        audioPlayer.clip = monsterSound;
        audioPlayer.volume = 0.1f;
        audioPlayer.Play();
        yield return new WaitForSeconds(audioPlayer.clip.length);
        location.image.sprite = sprite1;
        yield return new WaitForSeconds(2);
        audioPlayer.volume = 1f;
        audioPlayer.clip = transitionSound;
        location.image.sprite = tempSprite;
        hidden = false;
    }
    IEnumerator DeathScreen(Sprite dead)
    {
        if(currRoutine != null) {
            StopCoroutine(currRoutine);
        }
        GameObject.Find("AudioSource").GetComponent<AudioSource>().Stop();
        location.image.sprite = dead;
        audioPlayer.clip = deathSound;
        audioPlayer.Play();
        yield return new WaitForSeconds(5);
        audioPlayer.clip = transitionSound;
        hidden = false;
        SceneManager.LoadScene("start_screen");

    }


}
