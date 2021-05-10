using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    private Rigidbody _rb;

    private void Start()
    {
        _rb.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Debug.Log($"Collectible");

            _rb.velocity = new Vector3(0, 0, 0);
        }

        if (other.gameObject.CompareTag("Background"))
        {
        }
    }
}