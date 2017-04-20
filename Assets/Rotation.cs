using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float rotSpeed = 100;
    bool isPressed;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            isPressed = true;
        }

        if (!Input.GetMouseButton(1))
        {
            isPressed = false;
        }

        if (isPressed)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, rotY);
        }
    }
}