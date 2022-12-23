using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIMainGame : MonoBehaviour
{
    [SerializeField] private Pistol pistol;

    private TextMeshProUGUI ammoText;

    private int currentAmmo;
    private int clipSize;

    private void Start()
    {
        ammoText = GameObject.Find("AmmoText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        currentAmmo = pistol.currentAmmo;
        clipSize = pistol.clipSize;

        ammoText.text = $"Ammo: {currentAmmo}/{clipSize}";
    }
}

// NOTE: The reload reticule code is in gun.cs