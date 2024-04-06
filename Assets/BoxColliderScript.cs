using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoxColliderScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        direction_right = !direction_right; //changes player direction
    }
}