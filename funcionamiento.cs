using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionamiento : MonoBehaviour
{
    float rotacion = 10;

    void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotacion * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * rotacion * Mathf.Deg2Rad; 

        transform.RotateAround(Vector3.up, -rotx);
        transform.RotateAround(Vector3.right, roty);
    }
}
