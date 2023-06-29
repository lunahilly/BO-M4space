using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class LootSound : MonoBehaviour
{
    public AudioSource sound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))    // Als de speler tegen een enemy botst
        {
            sound.Play();
            Debug.Log(sound);
            gameObject.SetActive(false);
        }
    }
}
