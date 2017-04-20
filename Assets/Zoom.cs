using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

    float minFov = 1f;
    float maxFov = 99f;
    float sensitivity = 30f;
 
    void Update()
    {
        float fov = Camera.main.fieldOfView;
        fov += -Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }
}

