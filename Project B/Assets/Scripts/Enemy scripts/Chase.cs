using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    private int health = 60;
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
        if (col.gameObject.CompareTag("melee"))
        {
            health -= melee.damage;
        }
    }
}
