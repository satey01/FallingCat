using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    #region Privates and Protected

    public float moveSpeed;
    public float m_limitLeft;
    public float m_limitRight;

    #endregion Privates and Protected

    #region Unity API

    private void Start()
    {
        //moveSpeed = 2f;
        moveRight = true;
    }

    private void FixedUpdate()
    {
        if (transform.position.x > m_limitRight)

        {
            moveRight = false;
            transform.Rotate(0, 180, 0, Space.Self);
        }
        else if (transform.position.x < m_limitLeft)
        {
            moveRight = true;
            transform.Rotate(0, 180, 0, Space.Self);
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x + -moveSpeed * Time.deltaTime, transform.position.y);
        }
    }

    #endregion Unity API

    #region Private and Protected

    private bool moveRight;

    #endregion Private and Protected
}