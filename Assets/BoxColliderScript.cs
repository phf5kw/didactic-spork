using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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