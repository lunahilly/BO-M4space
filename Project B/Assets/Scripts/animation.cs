using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.A))
        {
            m_Animator.SetTrigger("A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Animator.SetTrigger("D");
        }
        if (!Input.anyKey)
        {
            m_Animator.SetTrigger("Idle");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Animator.SetTrigger("jump");
        }
        if ((Input.GetKey(KeyCode.LeftShift)))
        {
            m_Animator.SetTrigger("dash");
        }
        if ((Input.GetKey(KeyCode.LeftShift)))
        {
            m_Animator.SetTrigger("dashL");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Animator.SetTrigger("jumpL");
        }
    }
}
