using UnityEngine;
// using UnityEngine.SceneManagement;
using System.Collections;

public class DoorScene2 : MonoBehaviour
{   
    public GameObject levelTimer;
    public GameObject soundd;
    public GameObject text;
    public static int open;
    public GameObject doorClosed;

    void Start()
    {
        // Initialize the static variable open if needed
        open = 0;
        text.SetActive(false);
        doorClosed.SetActive(false);
        soundd.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            if (open == 1)
            {
                levelTimer.SetActive(false);
                soundd.SetActive(true);
                //SceneManager.LoadScene(3);
                GlobalScore.currenthealth = 0;
            }

            if(open == 0) 
            {
                text.SetActive(true);
                StartCoroutine(WaitForSec());
                doorClosed.SetActive(true);
                StartCoroutine(WaitForSec());
            }
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        text.SetActive(false);
        
    }

}
