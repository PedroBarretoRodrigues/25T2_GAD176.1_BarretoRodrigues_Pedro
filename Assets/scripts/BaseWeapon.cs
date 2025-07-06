using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    [SerializeField] private string weaponName;
    [SerializeField] private int weaponDamage;
    [SerializeField] private float fireRate;
    public GameObject projectilePrefab;
    public Transform firePoint;

    protected float nextFireTime;

    public virtual void Fire()
    {
        if(Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Debug.Log(weaponName + " attacked with " + weaponDamage + " damage.");
            Debug.Log($"{weaponName} fired!");
        }
       
    }
}
