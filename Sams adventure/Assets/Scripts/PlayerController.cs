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
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * movementSpeed);



       

        if (Input.GetButtonDown("Jump"))
    {
       rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z);
       //rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
    
    }    
}