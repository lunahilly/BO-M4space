using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{
    // Start is called before the first frame update
    public static int damage = 15;
    public Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
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
    }
}
