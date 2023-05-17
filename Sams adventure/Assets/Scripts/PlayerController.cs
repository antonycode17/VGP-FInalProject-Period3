using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float jumpheight = 5.0f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float forwardInput = Input.GetAxis("Horizontal");
       playerRb.AddForce(transform.forward * speed * forwardInput);  
    }
}
