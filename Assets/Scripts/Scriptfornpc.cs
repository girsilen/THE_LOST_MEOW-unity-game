using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptfornpc : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GlobalScore.currenthealth =  GlobalScore.currenthealth  - 100;
            GlobalScore2.currenthealth =  GlobalScore2.currenthealth  - 100;
        }
    }
            
}
