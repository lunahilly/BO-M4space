using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stationary : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 20;
    [SerializeField] AudioSource play;
    [SerializeField] AudioSource death;

    void Update()
    {
        if (health <= 0 || health == 0)
        {
            death.Play();
            Destroy(gameObject);
            DoorOpening.Enemy -= 1;
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
