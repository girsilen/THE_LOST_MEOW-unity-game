using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public GameObject footstep;

    void Start()
    {
        footstep.SetActive(false);
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0) // Check if player is moving
        {
            footsteps();
        }
        else
        {
            StopFootsteps();
        }
    }

    void footsteps() 
    {
        if (!footstep.activeSelf) // Ensure footstep object is not already active
        {
            footstep.SetActive(true);
            // Play footstep sound here if needed
        }
    }

    void StopFootsteps() 
    {
        if (footstep.activeSelf) // Ensure footstep object is active
        {
            footstep.SetActive(false);
        }
    }
}
