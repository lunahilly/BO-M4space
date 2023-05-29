using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public static int checkpoint = 0;
    public string Scene;

    //checkpoint 1 == level 1
    //checkpoint 2 == level 2
    //checkpoint 3 == level 3
    //checkpoint 4 == level 4

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Door"))
        {
            NextLevel.checkpoint += 1;
            SceneManager.LoadScene(Scene);
        }
    }
}
