using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private float speed = 3f;

    private void Update()
    {

        Vector2 distance = player.transform.position - this.transform.position;
        Vector3 direction = distance.normalized;


        transform.position += direction * speed * Time.deltaTime;
        //transform.LookAt(player.transform.position);
    }

}

