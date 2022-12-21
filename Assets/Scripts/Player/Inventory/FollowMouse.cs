using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FollowMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    bool hold = false;
    bool over = false;

    public Rigidbody2D item;
    public GameObject outline;
    public Vector2 input;

    void Start() {
        item = GetComponent<Rigidbody2D>();
        item.transform.position = new Vector2(459.4f, 200.2f);
    }

    void Update() {
        if (hold) {
           input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            item.velocity = input * 200;

            if (Input.GetKeyDown(KeyCode.R)) {
                item.MoveRotation(item.rotation + 10);
            } 
        } else {
            item.velocity = new Vector2(0, 0);
        }

        outline.SetActive(hold);

        if (over && Input.GetMouseButton(0)) {
            hold = true;
        } else if (Input.GetMouseButton(0)) {
            hold = false;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        over = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        over = false;
    }
}