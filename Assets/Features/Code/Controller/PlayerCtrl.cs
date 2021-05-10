using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    #region Exposed Members

    [SerializeField]
    [Tooltip("Set the speed Here")]
    private float _moveSpeed;

    // component
    [Tooltip("Set the Component Here")]
    private Transform _transform;

    private Rigidbody _rigibody;

    #endregion Exposed Members

    #region Unity API

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigibody = GetComponent<Rigidbody>();

        //_moveSpeed = 2f;
        _moveRight = true;
    }

    // Update is called once per frame
    private void Update()
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
            _transform.position = new Vector2(_transform.position.x + _moveSpeed * Time.deltaTime, _transform.position.y);
        }
        else
        {
            _transform.position = new Vector2(_transform.position.x - _moveSpeed * Time.deltaTime, _transform.position.y);
        }
    }

    #endregion Unity API

    #region Private and Protected

    // mechanic variable
    private bool _moveRight = true;

    #endregion Private and Protected
}