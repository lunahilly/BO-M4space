using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
    }
}
