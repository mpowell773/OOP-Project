using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    private Rigidbody projectileRb;

    [SerializeField] float forceModifier = 5;


    void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();

        //Adding force to projectile when instantiated
        projectileRb.AddRelativeForce(Vector3.forward * forceModifier, ForceMode.Impulse);
    }


}
