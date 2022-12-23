using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    // Variables \\
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected ParticleSystem muzzleFlashParticle;
    [SerializeField] protected Transform gunPoint;
    [SerializeField] protected Image reloadIndicator;

    public int clipSize { get; protected set; }
    public int currentAmmo { get; protected set; }
    public string gunName { get; protected set; }

    [SerializeField] protected float reloadSpeed;

    [SerializeField] protected float rateOfFire;

    private GameObject pistol;
    private GameObject smg;

    protected bool canShoot = true;
    protected bool isReloading = false;

    // Methods \\
    private void Start()
    {
        currentAmmo = clipSize;

        // There's probably a better way to go about this, but initially both guns are active
        // so they can be assigned as variables, then turn off smg by invoked SwitchGunTimer()
        pistol = GameObject.Find("Pistol");
        smg = GameObject.Find("SMG");
        StartCoroutine(SwitchGunTimer());
    }

    private IEnumerator SwitchGunTimer()
    {
        yield return new WaitForSeconds(.01f);
        smg.SetActive(false);
    }

    public virtual void ShootGun()
    {
        // Left Click fires weapon
        if (Input.GetMouseButton(0) && canShoot && currentAmmo > 0 && !isReloading)
        {
            muzzleFlashParticle.Play();
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
        float rotationSpeed = -200f;

        if (Input.GetKeyDown(KeyCode.R) && currentAmmo != clipSize)
        {
            isReloading = true;
            reloadIndicator.gameObject.SetActive(true);
            StartCoroutine(GunReloadingTimer());
        }

        if (isReloading)
        {
            reloadIndicator.transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
        }
    }

    protected IEnumerator GunReloadingTimer()
    {
        yield return new WaitForSeconds(reloadSpeed);
        currentAmmo = clipSize;
        isReloading = false;
        reloadIndicator.gameObject.SetActive(false);
    }

    public virtual void SwitchGun()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !isReloading)
        {
            if (pistol.activeSelf == true)
            {
                pistol.SetActive(false);
                smg.SetActive(true);
            }
            else
            {
                smg.SetActive(false);
                pistol.SetActive(true);
            }
        }   
    }
}
