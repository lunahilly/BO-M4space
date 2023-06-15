using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject meleeWeapon;
    public GameObject gunWeapon;
    public bool isMeleeWeaponActive = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isMeleeWeaponActive = !isMeleeWeaponActive;
            meleeWeapon.SetActive(isMeleeWeaponActive);
            gunWeapon.SetActive(!isMeleeWeaponActive);
        }
    }
}
