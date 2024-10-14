using UnityEngine;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // reference to rigidbody
    private Rigidbody playerRb;
    
    public float horizontalInput;
    public float speed;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) 
        {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
        }
    }

    // detects collisions
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
/*
        // prevents double jumping by recognizing the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        
    */
    }
}