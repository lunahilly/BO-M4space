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
        
    }
}
