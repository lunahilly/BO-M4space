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
            Debug.Log("testA");
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Animator.SetTrigger("D");
            Debug.Log("testD");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            m_Animator.SetTrigger("idle");
            Debug.Log("test");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            m_Animator.SetTrigger("idle");
            Debug.Log("test");
        }

    }
}
