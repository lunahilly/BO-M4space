using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator m_Animator;

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
            m_Animator.SetTrigger("AD");
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Animator.SetTrigger("AD");
        }
    }
}
