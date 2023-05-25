using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollide : MonoBehaviour
{
    public int Lives = 3;
    public GameObject Player;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))    // Als de speler tegen een enemy botst
        {
            Lives -=1;
        }
    }
    private void Update()
    {
        if (Lives == 0)
        {
            Destroy(heart1);
            Destroy(Player);
            SceneManager.LoadScene("Death");
        }
        if (Lives == 2)
        {
            Destroy(heart3);
        }
        if (Lives == 1)
        {
            Destroy(heart2);
        }
    }
}
