using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }

    public override void ShootGun()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, gunPoint.position, projectile.transform.rotation);
        }
        Debug.Log("Bang");
    }
}
