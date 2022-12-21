using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }

  
    public override void ShootGun()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Instantiate(projectile, gunPoint.position, projectile.transform.rotation);
            canShoot = false;
            StartCoroutine(GunShotRate());
        }
    }
   
}
