using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    bool canJump = false;
    bool isFalling = false;

    public Vector2 direction;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * speed;

        direction = new Vector2(inputX, body.velocity.y);

        body.velocity = direction;

        if (Input.GetKeyDown(KeyCode.Space) && canJump) {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (isFalling) {
            float fallSpeed = -3;
            body.velocity = new Vector2(inputX, fallSpeed);
            if (inputX != 0) {
                fallSpeed = fallSpeed * inputX;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Wall")) {
            isFalling = true;
        }

        if (col.CompareTag("Ground")) {
            canJump = true;
            isFalling = false;
        }
    }

    void OnTriggerStay2D(Collider2D col) {
        if (col.CompareTag("Ground")) {
            isFalling = false;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.CompareTag("Ground")) {
            canJump = false;
        }

        if (col.CompareTag("Wall")) {
            isFalling = false;
        }
    }
}
