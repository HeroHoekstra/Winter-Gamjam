using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Build : MonoBehaviour
{
    public Transform player;
    
    public void remove(GameObject build) {
        for (int i = 0; i < this.transform.childCount; i++) {
            GameObject parent = this.transform.GetChild(i).gameObject;
            for (int j = 0; j < parent.transform.childCount; j++)
            {
                GameObject image = parent.transform.GetChild(j).gameObject;
                if (image.tag == "Item") {
                    Destroy(image);
                }
            }
        }

        string path = "Assets/Resources/build.prefab";
        PrefabUtility.SaveAsPrefabAsset(build, path);
    }

    public void build() {
        //Create
        GameObject buildPrefab = Resources.Load<GameObject>("build");
        GameObject instance = Instantiate(buildPrefab);
        instance.transform.position = new Vector3(player.position.x, player.position.y + 2, 0);
        instance.transform.localScale = new Vector2(0.035f, 0.035f);

        for (int i = 0; i < instance.transform.childCount; i++) {
            GameObject parent = instance.transform.GetChild(i).gameObject;
            for (int j = 0; j < parent.transform.childCount; j++)
            {
                GameObject image = parent.transform.GetChild(j).gameObject;
                if (image.tag == "Item") {
                    Destroy(image);
                } else {
                    BoxCollider2D col = image.GetComponent<BoxCollider2D>();
                    col.isTrigger = false;

                    Rigidbody2D rb = image.GetComponent<Rigidbody2D>();
                    rb.constraints = rb.constraints & ~RigidbodyConstraints2D.FreezePositionY;
                    rb.constraints = rb.constraints & ~RigidbodyConstraints2D.FreezePositionX;
                    rb.constraints = rb.constraints & ~RigidbodyConstraints2D.FreezeRotation;
                    rb.gravityScale = 1;
                }
            }
        }

        //Remove
        AssetDatabase.DeleteAsset("Assets/Resources/build.prefab");

        for (int i = 0; i < this.transform.childCount; i++) {
            GameObject child = this.transform.GetChild(i).gameObject;
            Destroy(child);
        }
    }
}
