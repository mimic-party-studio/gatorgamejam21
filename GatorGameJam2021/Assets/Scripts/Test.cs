using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject playerobj;
    public GameObject textobj;

    // Start is called before the first frame update
    void Start()
    {
        playerobj.SetActive(true);
        textobj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
