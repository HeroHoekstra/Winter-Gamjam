using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddItem : MonoBehaviour
{
    public GameObject stick;

    void start() {
        stick = GetComponent<GameObject>();
    }

    public void addStick() {
        Instantiate(stick);
    }
}
