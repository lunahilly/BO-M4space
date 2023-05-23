using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string Scene;
    public void OnClick()
    {
        Debug.Log("button pressed");
        Debug.Log("Game loading...");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(Scene);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
