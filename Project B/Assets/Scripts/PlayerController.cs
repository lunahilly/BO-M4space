using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Weapon weapon;

    Vector2 moveDirection;
    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            weapon.Reload();
        }
    }
}
