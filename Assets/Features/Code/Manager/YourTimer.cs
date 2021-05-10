using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourTimer : MonoBehaviour
{
    #region Unity API

    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log($"{timer}");
    }

    #endregion Unity API

    #region Private and Protected

    private float timer = 0.0f;

    #endregion Private and Protected
}