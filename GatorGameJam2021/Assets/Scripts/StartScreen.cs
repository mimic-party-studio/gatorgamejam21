using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("first_area");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}