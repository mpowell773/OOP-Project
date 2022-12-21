using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected Transform gunPoint;

    [SerializeField] protected int ammoCount;
    [SerializeField] protected int currentAmmo;
    [SerializeField] protected float rateOfFire;
    [SerializeField] protected float reloadSpeed;

    protected bool canShoot = true;

    private void Start()
    {
        currentAmmo = ammoCount;
    }

    public virtual void ShootGun()
    {
        // Left Click fires weapon
        if (Input.GetMouseButton(0) && canShoot && currentAmmo > 0)
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

    }
}
