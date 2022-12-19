using UnityEngine;

public class respawncamps : MonoBehaviour
{
public Vector2 respawnpoint =  new Vector2(0,0);

    void Awake()
    {
        
    }
    void Update()
    {
     
    }
       void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Death")
        {
          die();  
        }
        if (collision.collider.tag == "Respawn")
        {
           respawn();
        }
    }

    void die(){
        transform.position = respawnpoint;
        Debug.Log("you have ded");
    }

    void respawn(){
         respawnpoint = new Vector2(0,0);
        Debug.Log("respawn point set");
    }
}
//* tag for death == ("Death")  and for respawning ("Respawn")