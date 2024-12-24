using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    //public static int button; // Changed to static
    // public GameObject lightt;

    // Start is called before the first frame update
    void Start()
    {
        glb.button = 0;
        // lightt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (glb.button == 0)
            {
                //lightt.SetActive(true);
                glb.button2.SetActive(true);
                glb.button = 0;
            }

            else if (glb.button == 1)
            {
                //lightt.SetActive(false);
                //glb.button1.SetActive(false);
                glb.button2.SetActive(true);
                //glb.button3.SetActive(false);
                glb.button = 2;
            }
            else if (glb.button == 3) 
            {
                glb.button1.SetActive(false);
                glb.button2.SetActive(false);
                glb.button3.SetActive(true);
                glb.button = 0;
            }
        }
    }
}
