using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float beltSpeed = 0.1f;

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)
        {
            rb.MovePosition(
                rb.position + transform.right * beltSpeed * Time.fixedDeltaTime
            );
        }
    }
}