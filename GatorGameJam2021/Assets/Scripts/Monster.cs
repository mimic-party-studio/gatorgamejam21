using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //if aggression 3 and ur not hiding, u die on next move
    //aggression affects text box and sound
    //every time u move, check if ur dead
    //if ur hiding and 3, image w monster. if 
    public int aggressionIndex;
    public int[] aggressionChart;
    // Start is called before the first frame update
 
    void Start()
    {
        int[][] options = {
            new int[] { 1,1,1,2,3 } ,
            new int[] { 1,1,2,3 },
            new int[] { 1,2,3 },
        };
        aggressionChart = options[Random.Range(0,2)];
        aggressionIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
