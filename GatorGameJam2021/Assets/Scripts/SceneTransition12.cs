using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition12 : MonoBehaviour
{
    public void goToTwo()
    {
        SceneManager.LoadScene("second_area");
    }
}
