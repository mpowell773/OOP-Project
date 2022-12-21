using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    private Rigidbody projectileRb;
    private Transform gunBody;
    private Transform gunPoint;

    [SerializeField] float forceModifier = 5;

    void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();
        gunBody = GameObject.Find("Pistol").transform;
        gunPoint = GameObject.Find("GunPoint").transform;

        Vector3 gunDirection = gunPoint.position - gunBody.position; 

        //Adding force to projectile when instantiated
        projectileRb.AddRelativeForce(gunDirection * forceModifier, ForceMode.Impulse);
    }
}
