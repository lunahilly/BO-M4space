using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject meleeWeapon;
    public GameObject gunWeapon;

    private bool isMeleeActive = true;

    private void Start()
    {
        gunWeapon.SetActive(false);
    }

    private void Update()
    {
        // Check for the "E" key press
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Switch between melee and gun weapons
            if (isMeleeActive)
            {
                SwitchToGun();
            }
            else
            {
                SwitchToMelee();
            }
        }
    }

    private void SwitchToGun()
    {
        // Deactivate the melee weapon
        meleeWeapon.SetActive(false);

        // Activate the gun weapon
        gunWeapon.SetActive(true);

        isMeleeActive = false;
    }

    private void SwitchToMelee()
    {
        // Deactivate the gun weapon
        gunWeapon.SetActive(false);

        // Activate the melee weapon
        meleeWeapon.SetActive(true);

        isMeleeActive = true;
        if (isMeleeActive == true)
        {
            //canFire = false;
        }
    }
}
