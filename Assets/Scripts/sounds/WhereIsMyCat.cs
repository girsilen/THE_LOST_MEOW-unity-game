using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereIsMyCat : MonoBehaviour
{
     public GameObject sounddd;
     public GameObject uiObject;

    void Start() 
    {
        sounddd.SetActive(false);
        uiObject.SetActive(false);
    }

    void OnTriggerEnter() 
    {
        sounddd.SetActive(true);
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
        //Invoke("Destroy", 1.0f);
    }

    IEnumerator WaitForSec() 
    {
        yield return new WaitForSeconds(2);
        Destroy(uiObject);
        //Destroy(gameObject);
        Invoke("Destroy", 1.0f);
    }

   private void Destroy()
   {
      Destroy(gameObject);
    }
}
