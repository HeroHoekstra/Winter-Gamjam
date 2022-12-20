using UnityEngine;

public class respawncamps : MonoBehaviour
{
public Vector2 respawnpoint =  new Vector2(0,0);
public int maxHealth = 100;
public int currentHealth;
public HealthBar healthBar;

    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Death")
        {
          TakeDamage(20);  
        }
        if (collision.collider.tag == "Respawn")
        {
           respawn();
        }
        if (currentHealth <=0)
        {
            die();
        }
    }

    void die()
    {
        transform.position = respawnpoint;
        Debug.Log("you have ded");
    }

    void respawn()
    {
         respawnpoint = new Vector2(0,0);
        Debug.Log("respawn point set");
    }
}
//* tag for death == ("Death")  and for respawning ("Respawn")