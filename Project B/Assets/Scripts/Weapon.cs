using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] float fireForce = 20f;
    [SerializeField] float rotationSpeed = 100f;
    //[SerializeField] float timeBetweenFiring = 0.5f;
    public static int Damage = 20;
    public int currentClip, maxClipSize = 5, currentAmmo, maxAmmoSize = 20;

    private Camera mainCam;
    private Vector3 mousePos;

    private void Start()
    {
        mainCam = Camera.main;
    }

    private void Update()
    {
        RotateWithMouse();
    }

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

    private void RotateWithMouse()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
