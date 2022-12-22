using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    private Rigidbody projectileRb;
    private Transform centerEye;
    private Transform gunPoint;

    [SerializeField] float forceModifier = 5;
    [SerializeField] float projectileRemovalTime = 10;

    private void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();
        centerEye = GameObject.Find("CenterEye").transform;
        gunPoint = GameObject.Find("GunPoint").transform;

        Vector3 gunDirection = (centerEye.position - gunPoint.position).normalized; 

        //Adding force to projectile when instantiated
        projectileRb.AddRelativeForce(gunDirection * forceModifier, ForceMode.Impulse);

        //Delete projectile after certain time period
        StartCoroutine(RemoveProjectileTimer());
    }

    private IEnumerator RemoveProjectileTimer()
    {
        yield return new WaitForSeconds(projectileRemovalTime);
        Destroy(gameObject);
    }
}
