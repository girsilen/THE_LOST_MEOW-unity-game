using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class npcai : MonoBehaviour
{
    
    public float moveSpeed = 5f;  
    public float moveDistance = 10f;

    private Vector3 startPos;   
    private Vector3 moveDirection = Vector3.right;  

    public GameObject ouch;
    public GameObject ouchSound;


    void Start()
    {
        startPos = transform.position; 
        transform.Rotate(Vector3.left, 90f);
        transform.Rotate(Vector3.right, 90f);
        ouch.SetActive(false);
        ouchSound.SetActive(false);

    }

    void Update()
    {
        // Calculate the target position based on the movement direction and distance
        Vector3 targetPos = startPos - moveDirection * moveDistance;

        // Move the object towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        // Check if the object has reached the target position
        if (Vector3.Distance(transform.position, targetPos) <= Mathf.Epsilon)
        {
            // If reached, reverse the direction of movement
            moveDirection = -moveDirection;
           // transform.Rotate(Vector3.left, 90f);
           transform.Rotate(Vector3.forward, 180f);
           //transform.Rotate(Vector3.up, -180f);
        }  
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ouch.SetActive(true);
            ouchSound.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        ouch.SetActive(false);
        //Destroy(gameObject);
    }

}
