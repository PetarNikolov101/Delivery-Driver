using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(){
        Debug.Log("bump");
    }

    void OnTriggerEnter2D() {
        Debug.Log("Trigger!");
    }
}


