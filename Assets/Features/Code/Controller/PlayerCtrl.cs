using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    #region Exposed Members

    [SerializeField]
    [Tooltip("Set the speed Here")]
    private float _horizontalSpeed;

    // component
    [Tooltip("Set the Component Here")]
    private Transform _transform;

    private Rigidbody _rb;

    #endregion Exposed Members

    #region Unity API

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();

        //_horizontalSpeed = 2f;
        _moveRight = true;
    }

    private void Update()
    {
        Movement();
    }

    #endregion Unity API

    #region Tools

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _moveRight == true)
        {
            _moveRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _moveRight == false)
        {
            _moveRight = true;
        }

        if (_moveRight)
        {
            _transform.position = new Vector2(_transform.position.x + _horizontalSpeed * Time.deltaTime, _transform.position.y);
        }
        else
        {
            _transform.position = new Vector2(_transform.position.x - _horizontalSpeed * Time.deltaTime, _transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.velocity = Vector3.zero;
        }
    }

    #endregion Tools

    #region Private and Protected

    // mechanic variable
    private bool _moveRight = true;

    #endregion Private and Protected
}