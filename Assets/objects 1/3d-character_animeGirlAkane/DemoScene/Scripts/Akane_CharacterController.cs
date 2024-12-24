using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akane_CharacterController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 3.0f; // Adjust the speed as needed
    private float jumpHeight = 1.0f; // Adjust the jump height as needed
    private float gravityValue = -9.81f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0.0f, vertical);

        // Calculate movement direction based on input
        if (move != Vector3.zero)
        {
            // Rotate the character towards the movement direction
            transform.forward = move.normalized;
            // Set animator parameter for walking
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        // Move the player based on the input, speed, and time
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Check for jump input and if the player is grounded
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            // Calculate the jump velocity to achieve desired jump height
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        // Apply gravity to the player's vertical velocity
        playerVelocity.y += gravityValue * Time.deltaTime;

        // Move the player based on the velocity
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
