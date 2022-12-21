using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected Transform gunPoint;

    [SerializeField] protected int ammoCount;
    [SerializeField] protected float rateOfFire;
    [SerializeField] protected float reloadSpeed;

    protected void ShootGun()
    {
        // Left Click fires weapon
        if (Input.GetMouseButton(0))
        {
            Instantiate(projectile, gunPoint.position, projectile.transform.rotation);
        }
    }
}
