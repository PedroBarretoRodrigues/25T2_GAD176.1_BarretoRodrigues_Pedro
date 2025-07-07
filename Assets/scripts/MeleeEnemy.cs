using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeleeEnemy : BaseEnemyStats
{
    // Melee enemy specific stats
    [SerializeField] private float meleeAttackRange = 2f; // The distance the enemy can attack.
    [SerializeField] private float meleeAttackDamage = 10f; // Amount of damage every attack.
    
    // Attack cooldown and time.
    [SerializeField] private float meleeAttackCooldown = 2f; // Cooldown in seconds between consecutive attacks.
    [SerializeField] private float lastAttackTime; // Tracking the last attack.

    // Overriding the Update function to use melee specific code.
    protected override void Update()
    {
        // This calls the base class's Update.
        base.Update(); 
        // Checking if the player is in the range of attack.
        if (Vector3.Distance(transform.position, player.position) <= meleeAttackRange)
        {
            Attack(); // Attacking if within range.   
             Debug.Log("The Melee enemy has done " + meleeAttackDamage + " to the player");
        }
        
    }
    // For the enemy attacking
    private void Attack()
    {
        // Checking to see if the cooldown has passed since the previous attack
        if (Time.time - lastAttackTime >= meleeAttackCooldown)
        {
           
            lastAttackTime = Time.time; 
        }
    }
}
