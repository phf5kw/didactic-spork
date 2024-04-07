using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float jumpForce = 3.0f;
    public float leapSpeed = 2.0f;
    public bool dir_right = true;
    public float wallGrav = 0.05f;
    public float gravityScale = 1f;
    Rigidbody2D rb;
    BoxCollider2D bc;

    // Start called on start
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        bc = this.GetComponent<BoxCollider2D>();
    }

    // your Jump code here
    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            gravityScale = 1f;
            if (dir_right)
            {
                rb.velocity = new Vector2(leapSpeed, jumpForce);
                //rb.AddForce(transform.up * jumpForce, transform.right * jumpForce);
            } else
            {
                rb.velocity = new Vector2(-leapSpeed, jumpForce);
                //rb.AddForce(transform.up * jumpForce, transform.left * jumpForce);
            }
            
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collide");
        if (col.gameObject.tag == "Right Wall")
        {
            rb.velocity = new Vector2(0, 0);
            gravityScale = wallGrav;
            Debug.Log("Hit right wall");
            dir_right = false; //changes player direction
        }
        else if (col.gameObject.tag == "Left Wall")
        {
            rb.velocity = new Vector2(0, 0);
            gravityScale = wallGrav;
            Debug.Log("Hit left wall");
            dir_right = true; //changes player direction
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Right Wall") {
            Debug.Log("On right wall");
        } else if (col.gameObject.tag == "Left Wall")
        {
            Debug.Log("On left wall");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Used for physics
    void FixedUpdate()
    {
        rb.gravityScale = 2f * gravityScale;
    }
}
