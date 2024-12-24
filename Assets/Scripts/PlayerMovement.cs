using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;

    public float moveSpeed = 2f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get movement input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized;

        // Rotate and animate the character if there's movement input
        if (movement != Vector3.zero)
        {
            transform.forward = movement; // Rotate the character towards the movement direction
            animator.SetBool("isWalk", true); // Trigger walking animation
        }
        else
        {
            animator.SetBool("isWalk", false); // Stop walking animation
        }

        // Move the character based on input
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
