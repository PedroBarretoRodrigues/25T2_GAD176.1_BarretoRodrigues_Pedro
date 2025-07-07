using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandling : MonoBehaviour
{
    public Transform weaponHolder; // reference to the parent object holding the weapon gameobjects.
    private int currentWeapon = 0; // Current weapon selection.

    // Start is called before the first frame update
    void Start()
    {
        WeaponSelect(); // Calling the Weapon select function.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Alpha1 is the number 1
        {
            currentWeapon = 0;
            WeaponSelect();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // Alpha2 is the number 2
        {
            currentWeapon = 1;
            WeaponSelect();
        }
    }

    // Activates and deactivates weapons
    void WeaponSelect()
    {   
        for(int i = 0; i < weaponHolder.childCount; i++) // to go through the weapon options.
        {
            weaponHolder.GetChild(i).gameObject.SetActive(i == currentWeapon); // Activating the weapon if its index matches what is called above.
        }
    }

}
