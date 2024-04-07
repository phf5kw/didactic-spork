using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 400f; 
    public bool direction_right = true;
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
        transform.Translate(6f * Time.deltaTime, 0f, 0f);
        movementController.Update();
    }
}

public class Wall : MonoBehavior
{
     Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
}

public class Movementcontroller : MonoBehaviour
{
    void Update()
    {
        if(direction_right){
            //go right
            transform.Translate(6f * Time.deltaTime, 0f, 0f);
        }
        else{
            //go left
            transform.Translate(-6f * Time.deltaTime, 0f, 0f);
        }
    }
}

public class BoxColliderScript : MonoBehaviour
{
    public Movementcontroller movementController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            movementController.direction_right = !direction_right; //changes player direction
        }
    }
}