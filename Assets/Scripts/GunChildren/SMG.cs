using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG : Gun
{

    private void Awake()
    {
        clipSize = 30;
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
        ReloadGun();
    }
}
