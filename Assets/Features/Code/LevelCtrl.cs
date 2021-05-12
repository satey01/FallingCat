using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : MonoBehaviour
{
    public TheLevelData m_Level;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        m_Level.justWon = false;
    }

    private void FixedUpdate()
    {
        if (!m_Level.justWon)
        {
            _rb.AddForce(Vector3.up * m_Level.currentScrollingSpeed);

            if (_rb.velocity.magnitude > m_Level.currentScrollingSpeed)
            {
                _rb.velocity = _rb.velocity.normalized * m_Level.currentScrollingSpeed;
            }
        }
        else if (m_Level.justWon)
        {
            Physics.autoSimulation = false;
        }
    }

    private Rigidbody _rb;
}