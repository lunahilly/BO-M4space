using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D rb;

    private bool canDash = true;
    private bool isDashing;
    public float dashingPower = 12f;
    public float dashingTime = 0.2f;
    public float dashingCooldown = 1f;

    [SerializeField] private TrailRenderer trail;

    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(StartDash());
        }
    }

    private IEnumerator StartDash()
    {
        canDash = false;
        isDashing = true;

        // Disable gravity while dashing
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;

        // Calculate the dash direction based on player input
        Vector2 dashDirection = Vector2.right * Input.GetAxisRaw("Horizontal") + Vector2.up * Input.GetAxisRaw("Vertical");
        if (dashDirection.magnitude == 0)
        {
            // If the player is not pressing any direction, default to right
            dashDirection = Vector2.right;
        }
        dashDirection.Normalize();

        // Apply the dash force
        rb.velocity = dashDirection * dashingPower;
        trail.emitting = true;

        // Wait for the dash time
        yield return new WaitForSeconds(dashingTime);

        // Stop the trail and restore gravity
        rb.velocity = Vector2.zero;
        trail.emitting = false;
        rb.gravityScale = originalGravity;

        // Wait for the dash cooldown and enable dashing again
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
        isDashing = false;

        yield break;
    }
}
