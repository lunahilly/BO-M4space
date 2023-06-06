using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    private int health = 60;
    [SerializeField] AudioSource play;
    [SerializeField] AudioSource death;

    void Update()
    {
        if (health <= 0 || health == 0)
        {
            death.Play();
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bullet"))
        {
            health -= Shooting.Damage;
            play.Play();
        }
        if (col.gameObject.CompareTag("melee"))
        {
            health -= melee.damage;
            play.Play();
        }
    }
}
