using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;

    void start() {
        inventory = GetComponent<GameObject>();
    }

    bool isOpen = false;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab)) {
            if (!isOpen) {
                isOpen = true;
            } else {
                isOpen = false;
            }
        }

        inventory.SetActive(isOpen);
    }
}
