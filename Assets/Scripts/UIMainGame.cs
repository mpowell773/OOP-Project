using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMainGame : MonoBehaviour
{
    [SerializeField] private Pistol pistol;
    [SerializeField] private SMG smg;

    private TextMeshProUGUI ammoText;
    private TextMeshProUGUI gunNameText;

    private int currentAmmo;
    private int clipSize;

    private void Start()
    {
        ammoText = GameObject.Find("AmmoText").GetComponent<TextMeshProUGUI>();
        gunNameText = GameObject.Find("GunNameText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (pistol.isActiveAndEnabled)
        {
            UpdateGunUI(pistol);
        }
        else
        {
            UpdateGunUI(smg);
        }

    }

    private void UpdateGunUI(Gun gun)
    {
        currentAmmo = gun.currentAmmo;
        clipSize = gun.clipSize;

        ammoText.text = $"Ammo: {currentAmmo}/{clipSize}";
        gunNameText.text = gun.gunName;
    }
}

//NOTE: Reload Indicator code in Gun.cs
//      Refactoring this code into UI is a later step