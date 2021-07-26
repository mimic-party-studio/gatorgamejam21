using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    //if aggression 3 and ur not hiding, u die on next move
    //aggression affects text box and sound
    //every time u move, check if ur dead
    //if ur hiding and 3, image w monster. if 
    public int aggressionIndex;
    public int[] aggressionChart;
    public GameObject status;
    Text statusText; 
    Dictionary<int, string> statusMessage;
    public GameObject thePlayer;
    public AudioSource scary;
    public AudioClip stage1;
        public AudioClip stage2;
    public AudioClip stage3;
    public int[][] options;

    // Start is called before the first frame update
 
    void Start()
    {
        scary = gameObject.GetComponent<AudioSource>();
        statusMessage = new Dictionary<int, string>();
        statusMessage.Add(0, "");
        statusMessage.Add(1, "i feel uneasy");
        statusMessage.Add(2, "i need to hide");
        statusMessage.Add(3, "please go away...");

        statusText = status.GetComponent<Text>();
        options = new int[3][];
        options[0] = new int[] { 0, 1,1,1,2,2,3 };
        options[1] = new int[] { 0,1,1,2,2,3 };
        options[2] = new int[] { 0, 0, 1,2,2,3 };

        Debug.Log(options[0]);
        
        // {
        //     new int[] { 0, 1,1,1,2,2,3 } ,
        //     new int[] { 0,1,1,2,2,3 },
        //     new int[] { 0, 0, 1,2,2,3 },
        // };
        aggressionChart = options[Random.Range(0,2)];
        aggressionIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //DO NOT ASSIGN MONSTER SCRIPT ON SCENES OTHER THAN OUTSIDE
        if(aggressionChart[aggressionIndex] == 1)
        {
            scary.clip = stage1;
        }
        else if(aggressionChart[aggressionIndex] == 2)
        {
            scary.clip = stage2;
        }
        else if(aggressionChart[aggressionIndex] == 3)
        {
            scary.clip = stage3;
        }
        statusText.text = statusMessage[aggressionChart[aggressionIndex]];
    }
}
