using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Controller : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public float jumpForce; // bird jump force
    public Rigidbody2D rb;


    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
