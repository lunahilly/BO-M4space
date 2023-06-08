using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Transform target;
    Transform enemyTransform;
    public float speed = 3f;
    public float rotationSpeed = 3f;


    void Start()
    {
        //obtain the game object Transform
        enemyTransform = this.GetComponent<Transform>();
    }

    void Update()
    {

        target = GameObject.FindWithTag("Player").transform;
        Vector3 targetHeading = target.position - transform.position;
        Vector3 targetDirection = targetHeading.normalized;

        //rotate to look at the player

        transform.rotation = Quaternion.LookRotation(targetDirection); // Converts target direction vector to Quaternion


        //move towards the player
        enemyTransform.position += enemyTransform.forward * speed * Time.deltaTime;

    }

}

