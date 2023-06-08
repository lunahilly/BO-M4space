using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] float fireForce = 20f;
    public int currentClip, maxClipSize = 5, currentAmmo, maxAmmoSize = 20;

    public void Fire()
    {
        if (currentClip > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            currentClip--;
        }
    }

    public void Reload()
    {
        int reloadAmmount = maxClipSize - currentClip;
        reloadAmmount = (currentAmmo - reloadAmmount) >= 0 ? reloadAmmount : currentAmmo;
        currentClip += reloadAmmount;
        currentAmmo -= reloadAmmount;
    }

    public void AddAmmo(int ammoAmmount)
    {
        currentAmmo += ammoAmmount;
        if (currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }
    }
}
