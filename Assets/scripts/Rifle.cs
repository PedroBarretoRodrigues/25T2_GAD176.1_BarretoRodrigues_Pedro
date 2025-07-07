using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : BaseWeapon
{
    // Start is called before the first frame update
    void Start()
    {
        weaponName = "Rifle"; // The name of the weapon.
        weaponDamage = 30; // The damage it does per shot.
        fireRate = 3f; // The time it takes between another shot.
    }

    public override void Fire()
    {
        base.Fire();
    }

}
