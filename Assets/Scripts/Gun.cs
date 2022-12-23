using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    // Variables \\
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected Transform gunPoint;

    public int clipSize { get; protected set; }
    public int currentAmmo { get; protected set; }

    [SerializeField] protected float reloadSpeed;

    [SerializeField] protected float rateOfFire;

    protected bool canShoot = true;
    protected bool isReloading = false;

    // Methods \\
    private void Start()
    {
        currentAmmo = clipSize;
    }

    public virtual void ShootGun()
    {
        // Left Click fires weapon
        if (Input.GetMouseButton(0) && canShoot && currentAmmo > 0 && !isReloading)
        {
            Instantiate(projectile, gunPoint.position, projectile.transform.rotation);
            canShoot = false;
            currentAmmo--;
            StartCoroutine(GunShotRate());
        }
    }

    protected IEnumerator GunShotRate()
    {
        yield return new WaitForSeconds(rateOfFire);
        canShoot = true;

    }

    public virtual void ReloadGun()
    {
        if (Input.GetKeyDown(KeyCode.R) && currentAmmo != clipSize)
        {
            isReloading = true;
            StartCoroutine(GunReloadingTimer());
        }
    }

    protected IEnumerator GunReloadingTimer()
    {
        yield return new WaitForSeconds(reloadSpeed);
        currentAmmo = clipSize;
        isReloading = false;
    }
}
