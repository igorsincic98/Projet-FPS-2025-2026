using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class AltInuputManager : MonoBehaviour



{
    private AltPlayerInput playerInput;

    private AltPlayerInput.OnFootActions onFoot;

    private AltPlayerMotor motor;
    
    private AltPlayerLook look;

    private AltPlayerInteract interact;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerInput = new AltPlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<AltPlayerMotor>();
        look = GetComponent<AltPlayerLook>();
        onFoot.Jump.performed += ctx => motor.Jump();
    }

    // Update is called once per frame
    void Update()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
        if (Input.GetKeyDown(AltPlayerInput.OnFootActions.Interact))
        {
            interact.Interact;
        }
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

}
