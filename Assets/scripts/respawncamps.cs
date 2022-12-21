using UnityEngine;

public class respawncamps : MonoBehaviour
{
    // Declare variables for the respawn point, max health, current health, and the health bar
    public Vector2 respawnPoint = new Vector2(0, 0);
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    void Start()
    {
        // Set the current health to the max health and update the health bar
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // Check if the current health is less than or equal to 0
        if (currentHealth <= 0)
        {
            // If it is, call the die() method
            Die();
        }
    }

    void OnCollision2D(Collider2D col) 
    {
        // Check if the collider has the "Death" tag
        if (col.tag == "enemy")
        {
            // If it does, call the TakeDamage() method and pass in the value 20 as an argument
            TakeDamage(20);
            Debug.Log("damage");
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        // Check if the collider has the "Respawn" tag
        if (collision.tag == "Respawn")
        {
            // If it does, call the respawn() method
            Respawn();
        }
    }

    void TakeDamage(int damage)
    {
        // Subtract the damage from the current health and update the health bar
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        // Set the position of the game object to the respawn point and log a message to the console
        transform.position = respawnPoint;
        Debug.Log("you have ded");
    }

    void Respawn()
    {
        // Set the respawn point to a new location and log a message to the console
        respawnPoint = new Vector2(71, 0);
        Debug.Log("respawn point set");
    }
}
