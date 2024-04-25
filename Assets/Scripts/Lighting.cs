using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public float azimuthAngle = 160f;

    void Start()
    {
        float rotationY = azimuthAngle - 90f;

        // Set the rotation of the directional light
        transform.rotation = Quaternion.Euler(90f, rotationY, 0f);
    }
}
