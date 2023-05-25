using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class Salsa : MonoBehaviour
{
    // Start is called before the first frame update

    //death by bullet

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bullet"))    // Als de speler tegen een enemy botst
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            DoorOpening.Enemy -= 1;
        }
    }
}
