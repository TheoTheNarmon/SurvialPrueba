using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicCameraScript : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float sensitivity;

    [Header("Assignment Slots")]
    [SerializeField] Transform player;
    
    float rotationUpDown = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotationUpDown -= y;
        rotationUpDown = Mathf.Clamp(rotationUpDown, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotationUpDown, 0, 0);

        player.Rotate(Vector3.up * x);
    }
}