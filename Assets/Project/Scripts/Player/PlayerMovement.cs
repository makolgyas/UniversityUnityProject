using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VariableJoystick joystic;
    public CharacterController controller;
    public float movementSpeed;
    public float rotationSpeed;


    public Canvas inputCanvas;
    public bool isJoystick;

    public Animator playerAnimator;

    private void Start()
    {
        EnableJoystickInput();
    }


    public void EnableJoystickInput()
    {
        isJoystick = true;
        inputCanvas.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (isJoystick)
        {
            var movementDirection = new Vector3(joystic.Direction.x, 0.0f, joystic.Direction.y);
            controller.SimpleMove(movementDirection * movementSpeed);

            if (movementDirection.sqrMagnitude <=0)
            {
                playerAnimator.SetBool("run", false);
                return;
            }

            playerAnimator.SetBool("run", true);
            var targetDirection = Vector3.RotateTowards(controller.transform.forward, movementDirection, rotationSpeed * Time.deltaTime, 0.0f);

            controller.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }

    
}





