using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;

    private PlayerInput.OnFootActions onFoot;

    private PlayerMotor motor;
    
    private PlayerLook look;

    private PlayerInteract interact;
    
    [SerializeField] private bool inventoryIsDisplayed;

    [SerializeField] private GameObject inventory;
    
    [SerializeField] private InventoryManager inventoryManager;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        onFoot.Jump.performed += ctx => motor.Jump(); 
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
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
    public void inventoryDisplay()
    {
        bool currentInventoryState = inventory.activeSelf;
        inventory.SetActive(!currentInventoryState);
        Cursor.lockState = CursorLockMode.None;
    }

}
