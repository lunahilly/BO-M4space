using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammos : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public GameObject bullet5;

    public Weapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (weapon.currentClip == 0)
        {
            bullet1.SetActive(false);
            bullet2.SetActive(false);
            bullet3.SetActive(false);
            bullet4.SetActive(false);
            bullet5.SetActive(false);
        }
        if (weapon.currentClip == 1)
        {
            bullet1.SetActive(true);
            bullet2.SetActive(false);
            bullet3.SetActive(false);
            bullet4.SetActive(false);
            bullet5.SetActive(false);
        }
        if (weapon.currentClip == 2)
        {
            bullet1.SetActive(true);
            bullet2.SetActive(true);
            bullet3.SetActive(false);
            bullet4.SetActive(false);
            bullet5.SetActive(false);
        }
        if (weapon.currentClip == 3)
        {
            bullet1.SetActive(true);
            bullet2.SetActive(true);
            bullet3.SetActive(true);
            bullet4.SetActive(false);
            bullet5.SetActive(false);
        }
        if (weapon.currentClip == 4)
        {
            bullet1.SetActive(true);
            bullet2.SetActive(true);
            bullet3.SetActive(true);
            bullet4.SetActive(true);
            bullet5.SetActive(false);
        }
        if (weapon.currentClip == 5)
        {
            bullet1.SetActive(true);
            bullet2.SetActive(true);
            bullet3.SetActive(true);
            bullet4.SetActive(true);
            bullet5.SetActive(true);
        }
    }
}
