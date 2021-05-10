using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Scrolling speed here")]
    private float _scrollingSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _rb.AddForce(Vector3.up * _scrollingSpeed);
    }

    private void FixedUpdate()
    {
        if (_rb.velocity.magnitude > _scrollingSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * _scrollingSpeed;
        }
    }

    private Rigidbody _rb;
}