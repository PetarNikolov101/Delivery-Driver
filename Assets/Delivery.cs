using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32(255,255,255,1);
    [SerializeField] Color32 hasPackageColor = new Color32(33,255,0,1);
    [SerializeField] float destroyDelay = 0f;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Delivered Package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}


