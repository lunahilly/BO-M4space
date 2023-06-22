using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class Guardian : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject homepoint;
    public float speed = 5f;

    [SerializeField] int health;
    [SerializeField] AudioSource death;
    public float hittime;
    public SpriteRenderer rend;

    public GameObject itemPrefab;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 4f && Vector3.Distance(player.transform.position, homepoint.transform.position) < 6f)
        {
            Vector2 distance = player.transform.position - this.transform.position;
            Vector3 direction = distance.normalized;


            transform.position += direction * speed * Time.deltaTime;
        }
        else if (Vector3.Distance(transform.position, player.transform.position) > 4f && Vector3.Distance(transform.position, homepoint.transform.position) < 6f && Vector3.Distance(transform.position, homepoint.transform.position) > 0.5f)
        {
                Vector2 distance = homepoint.transform.position - this.transform.position;
                Vector3 direction = distance.normalized;


                //transform.position = Vector3.MoveTowards(transform.position, homepoint.transform.position, speed * Time.deltaTime);
                transform.position += direction * speed * Time.deltaTime;


        }

        if (health <= 0 || health == 0)
        {
            //GetComponent<LootBag>().InstatiateLoot(transform.position);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
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
