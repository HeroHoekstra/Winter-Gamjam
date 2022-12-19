using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    //To add more items make another thing
    public int amountWood = 0;
    public TextMeshProUGUI wood;

    void start() {
        inventory = GetComponent<GameObject>();
    }

    bool isOpen = false;
    // Update is called once per frame
    void Update()
    {
        wood.text = amountWood.ToString();

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
