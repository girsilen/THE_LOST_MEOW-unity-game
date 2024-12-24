using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script32 : MonoBehaviour
{
    //public static int button; // Changed to static
    public GameObject lightt;
    public GameObject boxx;
    //public GameObject keyphoto;

    // Start is called before the first frame update
    void Start()
    {
        glb.button = 0;
        boxx.SetActive(true);
        //keyphoto.SetActive(false);
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
                glb.button3.SetActive(true);
                glb.button = 1;
            }

            else if (glb.button == 1)
            {
                //lightt.SetActive(false);
                glb.button1.SetActive(false);
                glb.button2.SetActive(false);
                glb.button3.SetActive(false);
                glb.button = 0;
            }
            else if (glb.button == 2) 
            {
                //glb.button1.SetActive(false);
                //glb.button2.SetActive(false);
                glb.button3.SetActive(true);
                //glb.button = 3;
                boxx.SetActive(false);
                //keyphoto.SetActive(true);


            }
        }
    }
}
