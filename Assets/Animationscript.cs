using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animationscript : MonoBehaviour
{
    private Animator anim;
    private bool grounded;

  
    private void Awake()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        

        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);

        if (Input.GetKey(KeyCode.Space) && grounded)
            Jump();
    }

    private void Jump()
    {
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
