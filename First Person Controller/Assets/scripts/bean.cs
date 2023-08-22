using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bean : MonoBehaviour
{
    float speed = 5;
    float jumpSpeed = 5;
    public static bool isGrounded = false;

    Rigidbody rb;
    Transform tf;
    AudioSource au;
    Vector3 moveDirection; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GameObject.Find("horizontal rotator").GetComponent<Transform>();
        au = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        moveDirection = (tf.forward * Input.GetAxis("Vertical")) + tf.right * Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") != 0 && Input.GetAxis("Horizontal") != 0)
        {
            rb.velocity = new Vector3((moveDirection.x * speed) / Mathf.Sqrt(2), rb.velocity.y, (moveDirection.z * speed) / Mathf.Sqrt(2));
        } else
        {
            rb.velocity = new Vector3(moveDirection.x * speed, rb.velocity.y, moveDirection.z * speed);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
    }
}

