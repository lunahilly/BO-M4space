using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stationary : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 20;
    [SerializeField] AudioSource play;

    void Update()
    {
        if (health <= 0 || health == 0)
        {
            play.Play();
            Destroy(gameObject);
            DoorOpening.Enemy -= 1;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bullet"))
        {
            health -= Shooting.Damage;
        }
    }
}
