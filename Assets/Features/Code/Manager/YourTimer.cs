using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourTimer : MonoBehaviour
{
    private float timer = 0.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log($"{timer}");
    }
}