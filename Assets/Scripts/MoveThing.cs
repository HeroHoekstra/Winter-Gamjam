using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThing : MonoBehaviour
{
    /*bool hold = false;
    public Rigidbody2D item;

    void Start() {
        item = GetComponent<Rigidbody2D>();
    }

    void Update() {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (hold) {
            item.transform.position = worldMousePosition;
        }

        Debug.Log(worldMousePosition);
    }

    void OnMouseDown()
    {
        hold = true;
    }

    void OnMouseUp() {
        hold = false;
    }*/
    // Flag to track if the object is being dragged
    /*private bool isDragging = false;

    void Update()
    {
        // Check if the left mouse button is down
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the mouse is over the object
            if (IsMouseOverObject())
            {
                // Start dragging the object
                isDragging = true;
            }
        }
        // Check if the left mouse button is up
        if (Input.GetMouseButtonUp(0))
        {
            // Stop dragging the object
            isDragging = false;
        }

        // If the object is being dragged, follow the mouse
        if (isDragging)
        {
            FollowMousePosition();
        }
    }

    // Returns true if the mouse is over the object
    bool IsMouseOverObject()
    {
        // Create a ray from the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Check if the ray intersects the object's collider
        RaycastHit hit;
        if (GetComponent<Collider2D>().Raycast(ray, out hit, Mathf.Infinity))
        {
            return true;
        }

        return false;
    }

    // Makes the object follow the mouse position
    void FollowMousePosition()
    {
        // Convert the mouse position to world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Set the object's position to the mouse position
        transform.position = mousePosition;
    }*/
}
