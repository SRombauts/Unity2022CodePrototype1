using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed settings
    public float maxForwardSpeed = 20.0f;
    public float maxRotationSpeed = 50.0f;

    // Update is called once per frame (before LateUpdate that we user for the camera)
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float lateralInput = Input.GetAxis("Horizontal");

        float forwardSpeed = forwardInput * maxForwardSpeed;
        float rotationSpeed = lateralInput * maxRotationSpeed * forwardInput;

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
    }
}