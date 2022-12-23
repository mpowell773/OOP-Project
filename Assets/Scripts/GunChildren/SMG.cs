using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG : Gun
{

    private void Awake()
    {
        clipSize = 30;
        gunName = "smg";
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
        ReloadGun();
        SwitchGun();
    }
}
