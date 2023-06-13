using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollide : MonoBehaviour
{
    public static int Lives = 3;
    public GameObject Player;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    [SerializeField] AudioSource hit;
    [SerializeField] AudioSource death;

    public SpriteRenderer rend;
    public float hittime;    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))    // Als de speler tegen een enemy botst
        {
            wait();
            Lives -=1;
        }
        if (col.gameObject.CompareTag("Lava"))    // Als de speler tegen een enemy botst
        {
            Destroy(Player);
            SceneManager.LoadScene("Death");
        }
        if (col.gameObject.CompareTag("spikes"))    // Als de speler tegen een enemy botst
        {
            Lives -= 1;
            wait();
        }
    }
    private void Update()
    {
        if (Lives == 0)
        {
            Destroy(heart1);
            Destroy(Player);
            SceneManager.LoadScene("Death");
            death.Play();
        }
        if (Lives == 2)
        {
            Destroy(heart3);
            hit.Play();
        }
        if (Lives == 1)
        {
            Destroy(heart2);
            Destroy(heart3);
            hit.Play();
        }
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
