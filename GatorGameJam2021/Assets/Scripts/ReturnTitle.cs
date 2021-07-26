using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    void OnStart()
    {
        StartCoroutine("thing");
    }
    IEnumerator thing()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
}
