using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 400f;
    Rigidbody2D rb;

    // Start called on start
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // your Jump code here
    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb.AddForce(Vector3.up * rb.mass * jumpForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(direction_right){
            //go right
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        else{
            //go left
            transform.Translate(-5f * Time.deltaTime, 0f, 0f);
        }
    }
}
