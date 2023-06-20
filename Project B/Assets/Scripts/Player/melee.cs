using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    private Camera mainCam;
    private Vector3 mousePos;

    public static int damage = 15;
    public Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();

        mainCam = Camera.main;
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.Mouse0))
        {
            m_Animator.SetTrigger("click");
        }
        if (!Input.anyKey)
        {
            m_Animator.SetTrigger("idle");
        }

        RotateWithMouse();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Goober enemy = collision.GetComponent<Goober>();
            enemy.HandleHit(damage);
        }
    }

    private void RotateWithMouse()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
