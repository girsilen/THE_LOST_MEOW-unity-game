using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script1 : MonoBehaviour
{
    //public static int button; // Changed to static
    // public GameObject lightt;

    // Start is called before the first frame update
    void Start()
    {
        glb.button = 0;
        // lightt.SetActive(false);
       // glb.button1.SetActive(false);
        //glb.button2.SetActive(false);
       // glb.button3.SetActive(false);  
       //Keys.keyPhoto.SetActive(false); 
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
                glb.button1.SetActive(true);
                glb.button = 1;
            }

            else if (glb.button == 1)
            {
                glb.button1.SetActive(false);
                glb.button2.SetActive(false);
                glb.button3.SetActive(false);
                glb.button = 0;
            }
            else if (glb.button == 2) 
            {
                glb.button1.SetActive(false);
                glb.button2.SetActive(false);
                glb.button3.SetActive(false);
                glb.button = 0;
            }
        }
    }
}
