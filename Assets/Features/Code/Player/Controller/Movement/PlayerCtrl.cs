using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    #region Exposed Members

    [SerializeField]
    [Tooltip("Set the Horizontal speed Here")]
    private float _horizontalSpeed;

    // component
    [Tooltip("Set the Component Here")]
    private Transform _transform;

    public PlayerData player;

    #endregion Exposed Members

    #region Unity API

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();

        //_horizontalSpeed = 2f;
        _moveRight = true;
        player._isFreeze = false;
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

        //if (Input.GetKeyDown(KeyCode.N) && _isFreeze == false)
        //{
        //    _isFreeze = true;
        //}
        //else if (Input.GetKeyDown(KeyCode.N) && _isFreeze == true)
        //{
        //    _isFreeze = false;
        //}

        if (player._isFreeze == false)
        {
            if (_moveRight)
            {
                _transform.position = new Vector2(_transform.position.x + _horizontalSpeed * Time.deltaTime, _transform.position.y);
            }
            else if (_moveRight == false)
            {
                _transform.position = new Vector2(_transform.position.x - _horizontalSpeed * Time.deltaTime, _transform.position.y);
            }
        }
        else if (player._isFreeze == true)
        {
            _transform.position = _transform.position;
        }
    }

    #endregion Tools

    #region Private and Protected

    // mechanic variable
    private bool _moveRight = true;

    private Rigidbody _rb;

    #endregion Private and Protected
}