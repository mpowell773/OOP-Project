using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected int ammoCount;
    [SerializeField] protected float rateOfFire;
    [SerializeField] protected float reloadSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void ShootGun()
    {
        // Left Click fires weapon
        if (Input.GetMouseButton(0))
        {
            
        }
    }
}
