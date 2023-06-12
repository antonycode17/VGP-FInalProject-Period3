using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Body"))
        {
            Die();
        }
    }


    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<RigidBody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
    }
    
}
