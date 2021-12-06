using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    
    // How fast the mouse is going to move
    public float Sensitivity = 100f;
    public Transform player1;
    float xRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Catch mouse axis and multiply with sensitivity
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        // Up and down movement
        xRotation -= mouseY;
        // Add limitations to mouse movement
        xRotation = Mathf.Clamp(xRotation, -90f, 75f);

        // Rotation about the axis (Store rotations)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player1.Rotate(Vector3.up * mouseX);
    }
}
