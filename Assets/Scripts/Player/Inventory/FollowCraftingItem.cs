using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCraftingItem : MonoBehaviour
{
    public Transform craftingItem;
    Rigidbody2D _item;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (craftingItem != null) {
            transform.position = craftingItem.transform.position;
            transform.rotation = craftingItem.transform.rotation;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Vector3 triggerLocation = col.bounds.center;
        Vector3 triggerOfset = triggerLocation - transform.position;

        if (this.tag == "Stick") {
            if (col.gameObject.tag == "Rope") {
                HingeJoint2D hingeJoint = gameObject.AddComponent<HingeJoint2D>();
                hingeJoint.connectedBody = col.GetComponent<Rigidbody2D>();
                hingeJoint.anchor = triggerOfset / 100;
            }
        }
    }
}
