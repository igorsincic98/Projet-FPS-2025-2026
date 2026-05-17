using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    PlayerInput playerInput;

    private Vector3 playerVelocity;

    public float speed = 5f;
    private bool isGrounded;
    public float gravity = 9.8f;
    public float jumpHeight = 3f;

    public float sprintSpeed = 2f;
    private Vector3 _velocity;

    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        _rb = GetComponent<Rigidbody>();
        _velocity = _rb.linearVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        /*
        if (Input.GetButton("Sprint") && isGrounded)
        {
            speed = 5f * sprintSpeed;
        }
        */

        /*if (_velocity.magnitude <= 0f)
        {
            speed = 5f;
        }*/
            
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * (speed * Time.deltaTime));
        playerVelocity.y += -gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        controller.Move(playerVelocity * Time.deltaTime);
        //Debug.Log(playerVelocity.y);
    }

    
    /*public void SprintState()
    {
        speed = 5f;
        speed = speed * sprintSpeed;
    }*/
    
    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * 3f * gravity);
        }
    }

}
