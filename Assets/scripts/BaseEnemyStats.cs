using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStats : MonoBehaviour
{
    [SerializeField] private float health = 100f; // Enemies starting Health stats.
    [SerializeField] private float movementSpeed = 5f; // How fast the enemies move.

    public Transform player; // Getting a reference to the players position.


    protected virtual void Update()
    {
        // Calling the function that moves the AI towards the player.
        TrackPlayer();
    }

    // A function for the AI to track the player and move towards it.
    protected void TrackPlayer()
    {
        if(player != null)
        {
            // This calculates what direction the player is to the enemy.
            Vector3 direction = (player.position - transform.position).normalized;

            // This moves the enemy in that direction at a certain speed.
            transform.position += direction * movementSpeed * Time.deltaTime;
        }
    }

    // This function is how and how much the enemy will take damage
    public void EnemyTakeDamage(float amount)
    {
        // Will lower the enemy health by a certain amount
        health -= amount;
        if (health <= 0)
        {
            // Calling this function if the enemy reaches 0 or less health.
            Die(); 
        }
    }

    protected void Die()
    {
        // Destroys the enemy 
        Destroy(gameObject);
    }
}
