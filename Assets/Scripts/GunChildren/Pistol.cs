using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{

    private void Awake()
    {
        clipSize = 7;
        gunName = "pistol";
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
        ReloadGun();
        SwitchGun();
    }

  
    public override void ShootGun()
    {
        if (Input.GetMouseButtonDown(0) && canShoot && currentAmmo > 0 && !isReloading)
        {
            Instantiate(projectile, gunPoint.position, projectile.transform.rotation);
            canShoot = false;
            currentAmmo--;
            StartCoroutine(GunShotRate());
        }
    }
   
}
