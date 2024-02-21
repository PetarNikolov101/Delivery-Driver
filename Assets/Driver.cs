using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 250f;
    [SerializeField]float moveSpeed = 20f;
    [SerializeField]float slowSpeed = 17f; 
    [SerializeField]float boostSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm a car");
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;        
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
