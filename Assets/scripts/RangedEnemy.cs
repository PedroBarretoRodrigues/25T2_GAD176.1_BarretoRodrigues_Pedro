using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : BaseEnemyStats
{
    // Ranged enemy specific stats
    [SerializeField] private float attackRange = 10f; // The distance the enemy can attack.
    [SerializeField] private float attackDamage = 5f; // Amount of damage every attack.
  
    // Attack cooldown and time.
    [SerializeField] private float attackCooldown = 5f; // Cooldown in seconds between consecutive attacks.
    [SerializeField] private float lastAttackTime; // Tracking the last attack.

    public GameObject projectileRangePrefab; // The prefab for the range enemy to fire.

    // Overriding the Update function to use ranged specific code.
    protected override void Update()
    {
        // This calls the base class's Update.
        base.Update();

        // Calculates the direction to the player.
        Vector3 directionToPlayer = player.position - transform.position;

        // Checking to see if the player is within the range of attack.
        if (directionToPlayer.magnitude <= attackRange)
        {
            // Finding the target rotation.
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
            // Applying it only on the Y axis
            transform.rotation = Quaternion.Euler(0, targetRotation.eulerAngles.y, 0);
        }

        // Checking if the player is in the range of attack.
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            Attack(); // Attacking if within range.   
           
        }

    }
    // For the enemy attacking.
    private void Attack()
    {
        // Checking to see if the cooldown has passed since the previous attack.
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            GameObject projectile = Instantiate(projectileRangePrefab, transform.position + transform.forward, transform.rotation);

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * 20f;
            }

            lastAttackTime = Time.time;
        }
    }
}
