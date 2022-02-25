using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 _deltaPosition;

    private void Start()
    {
        _deltaPosition = Camera.main.transform.position - transform.position;
    }

    private void Update()
    {
        Camera.main.transform.position = transform.position + _deltaPosition;
    }
}
