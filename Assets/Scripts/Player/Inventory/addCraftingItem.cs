using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addCraftingItem : MonoBehaviour
{
    public GameObject item;
    public GameObject parentObject;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    public void addItem() {
        GameObject addItem = Instantiate(item);
        addItem.transform.parent = parentObject.transform; 
    }
}
