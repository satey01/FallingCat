using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    private Rigidbody _rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Parachute"))
        {
            Debug.Log($"parachute");

            _rb.velocity = new Vector3(0, 10, 0);
        }

        if (other.gameObject.CompareTag("Background"))
        {
        }
    }
}