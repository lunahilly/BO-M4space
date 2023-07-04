using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string Scene;
    //checkpoint 1 == level 1
    //checkpoint 2 == level 2
    //checkpoint 3 == level 3
    //checkpoint 4 == level 4
    public void OnClick()
    {
        Debug.Log("button pressed");
        Debug.Log("Game loading...");
        DeathCollide.Lives = 3;
        

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(Scene);
    }
    public void Start()
    {
        if (NextLevel.checkpoint == 0)
        {
            Scene = "Ship-tutorial";
        }
        if (NextLevel.checkpoint == 1)
        {
            Scene = "Level 1";
        }
        if (NextLevel.checkpoint == 2)
        {
            Scene = "Level 2";
        }
        if (NextLevel.checkpoint == 3)
        {
            Scene = "Level 3";
        }
        if (NextLevel.checkpoint == 4)
        {
            Scene = "Level 4";
        }
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
