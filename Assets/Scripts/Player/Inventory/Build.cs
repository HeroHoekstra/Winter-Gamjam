using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public void remove(GameObject parent) {
        int childCount = parent.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = parent.transform.GetChild(i);
            Destroy(child.gameObject);
        }
    }
}
