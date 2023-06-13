using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goober : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioSource death;
    public float hittime;
    public SpriteRenderer rend;

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
            wait();
        }
    }

    public void HandleHit(int damage)
    {
        health -= damage;
        Debug.Log("test");
        wait();
    }

    private IEnumerator Hit(float time)
    {
        rend.color = Color.red;
        yield return new WaitForSeconds(time);
        rend.color = Color.white;
    }

    public void wait()
    {
        StartCoroutine(Hit(hittime));
    }
}
