using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float movementSpeed = 6f;
    float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        if (Input.GetButtonDown("Jump"))
    {
       rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z);
    }
    
    }    
}