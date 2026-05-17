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
    [SerializeField] private bool _cursorLocked;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        onFoot.Jump.performed += ctx => motor.Jump(); 
        Cursor.lockState = CursorLockMode.Locked;
        _cursorLocked = true;

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
    }
    public void CursorLockSwitch()
    {
        if (_cursorLocked)
        {
        Cursor.lockState = CursorLockMode.None; 
        Debug.Log("Cursor unlocked");
        _cursorLocked = false;
        return;
        }

        if (_cursorLocked = false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Cursor locked");
            return;
        }
    }

}
