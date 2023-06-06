using UnityEngine;

public class WallJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public float wallSlideSpeed = 2f;

    private bool isWallSliding;
    private bool isJumping;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isWallSliding)
            {
                WallJumpAction();
            }
            else if (!isJumping)
            {
                Jump();
            }
        }
    }

    private void FixedUpdate()
    {
        if (isWallSliding)
        {
            rb.velocity = new Vector2(rb.velocity.x, -wallSlideSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isWallSliding = true;
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isWallSliding = false;
        }
    }

    private void WallJumpAction()
    {
        isWallSliding = false;
        isJumping = true;

        float jumpDirection = Mathf.Sign(transform.localScale.x);
        rb.velocity = new Vector2(jumpDirection * jumpForce, jumpForce);
    }

    private void Jump()
    {
        isJumping = true;
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (isJumping && collision.gameObject.CompareTag("Wall"))
        {
            isJumping = false;
        }
    }
}
