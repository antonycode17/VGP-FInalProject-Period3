using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private float movementSpeed = 6f;
    public float jumpForce = 5f;

    private Transform groundCheck;
    private LayerMask ground;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * -1 * movementSpeed);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * -1 * movementSpeed);



       

        if (Input.GetButtonDown("Jump"))
    {
       rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z);
       //rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
    
    }    

   // bool IsGrounded()
    // {
       // return Physics.CheckSphere(groundCheck.positions, .1f, ground);
    // }
}