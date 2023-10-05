using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterTankController : MonoBehaviour
{
     public float moveSpeed = 3f;
     public float turnSpeed = 30f;
     public float gravity = 9.8f;

    public CharacterController _cc;
   // si, es muy simple este codigo xd
    private void Awake()
    {
        _cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _cc.Move(transform.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _cc.Move(transform.forward * moveSpeed * Time.deltaTime * (-0.3f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        }

        ApplyGravity();
    }


    private void ApplyGravity()
    {
        Vector3 fallVelocity = new Vector3(0f, -gravity, 0f);
        _cc.Move(fallVelocity * Time.deltaTime);
    }
}
