using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : MonoBehaviour
{
    public TheLevelData m_Level;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _rb.AddForce(Vector3.up * m_Level.currentScrollingSpeed);
    }

    private void FixedUpdate()
    {
        if (_rb.velocity.magnitude > m_Level.currentScrollingSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * m_Level.currentScrollingSpeed;
        }
    }

    private Rigidbody _rb;
}