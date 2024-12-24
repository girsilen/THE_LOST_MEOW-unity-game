using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai : MonoBehaviour
{
    public GameObject player;

    private NavMeshAgent agent;

    [SerializeField] private LayerMask groundLayer, playerLayer;

    // Patrol variables
    private Vector3 desPoint;
    private bool walkpointSet = false;
    [SerializeField] private float range = 20f;

    // Trigger variables
    public GameObject ouch;
    public GameObject ouchSound;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        ouch.SetActive(false);
        ouchSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if (!walkpointSet)
        {
            SearchForDesPoint();
        }

        if (walkpointSet)
        {
            agent.SetDestination(desPoint);
        }

        if (Vector3.Distance(transform.position, desPoint) < 1f) // Adjusted the threshold distance
        {
            walkpointSet = false;
        }
    }

    void SearchForDesPoint()
    {
        float z = Random.Range(-range, range);
        float x = Random.Range(-range, range);

        desPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if (Physics.Raycast(desPoint + Vector3.up * 10, Vector3.down, 20f, groundLayer))
        {
            walkpointSet = true;
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
        ouchSound.SetActive(false);
        //Destroy(gameObject);
    }
}
