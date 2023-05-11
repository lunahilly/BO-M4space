using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5;

    private Rigidbody2D _rb;
    [SerializeField]
    private float jumpPower;


    public bool IsGrounded = true;
    public int IsJumping = 0;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector2 dir = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            dir += new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            dir += new Vector2(1, 0);
        }
        transform.Translate(dir * moveSpeed * Time.deltaTime);

        if (IsGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            IsJumping ++;
        }
        if (IsJumping == 2)
        {
            IsGrounded= false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            IsJumping = 0;
        }
    }
    private void Jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, jumpPower);
    }

}
