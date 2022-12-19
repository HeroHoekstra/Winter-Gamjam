using UnityEngine;

public class win_camp : MonoBehaviour
{
public Vector2 respawnpoint =  new Vector2(-16,5);

    void Awake()
    {
        
    }
    void Update()
    {
     
    }
       void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "win")
        {
           win();
        }
    }

    void win(){
        Debug.Log("win");
    }
}
//*  tag == ("win") 