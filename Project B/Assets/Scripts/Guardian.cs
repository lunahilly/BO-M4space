using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class Guardian : MonoBehaviour
{
    // Start is called before the first frame update

    private int health = 100;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 || health == 0)
        {
            Destroy(gameObject);
            DoorOpening.Enemy -= 1;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bullet"))    // Als de speler tegen een enemy botst
        {
            health -= 20;
        }
    }
}
