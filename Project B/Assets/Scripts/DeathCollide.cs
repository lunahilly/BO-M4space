using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollide : MonoBehaviour
{
    public int Lives = 3;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))    // Als de speler tegen een PowerUp botst
        {
            Lives -=1;
        }
    }
    private void Update()
    {
        if (Lives == 0)
        {
            Destroy(Player);
            SceneManager.LoadScene("Death");
        }
    }
}
