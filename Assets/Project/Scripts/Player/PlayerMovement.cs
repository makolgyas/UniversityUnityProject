using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public FixedJoystick joystick;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized;
        rb.velocity = move * moveSpeed;
    }
}

