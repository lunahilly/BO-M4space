using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goober : MonoBehaviour
{
    [SerializeField] int health;
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
        }
    }

    public void HandleHit(int damage)
    {
        health -= damage;
        Debug.Log("test");
    }
}
