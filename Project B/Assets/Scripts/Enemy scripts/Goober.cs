using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goober : MonoBehaviour
{
    private int health = 40;
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
