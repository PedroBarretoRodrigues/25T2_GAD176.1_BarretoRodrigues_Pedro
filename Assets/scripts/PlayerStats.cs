using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int currentHealth; // Current updated health for when the player takes damage.
    public int maxHealth = 100; // The max health of the player.

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Updating the current health to the max health at the beginning of the scene.
    }

    // Function for taking damage.
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Updated health when the player takes damage.
        Debug.Log("OH NO! The player has taken damage. Current health is now: " + currentHealth);

        // If the player has less or equal to 0 health PlayerDeath() gets called.
        if (currentHealth <= 0)
        {
            PlayerDeath();
        }

    }

    // For when the player dies.
    public void PlayerDeath()
    {
        Destroy(gameObject); // Kills the player.
        Debug.Log("YOU HAVE DIED!");
        // Restarts the scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
