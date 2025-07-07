using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : BaseWeapon
{
    // Start is called before the first frame update
    void Start()
    {
        weaponName = "Pistol"; // The name of the weapon.
        weaponDamage = 15; // The damage it does per shot.
        fireRate = 0.5f; // The time it takes between another shot.
    }

    public override void Fire()
    {
            base.Fire();

    }

}
