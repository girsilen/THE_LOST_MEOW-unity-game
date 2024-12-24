using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereAmI : MonoBehaviour
{
    public GameObject soundd;
    public GameObject uiObject;

    void Start() 
    {
        soundd.SetActive(false);
        uiObject.SetActive(false);
    }

    void OnTriggerEnter() 
    {
        soundd.SetActive(true);
        //Invoke("Destroy", 1.0f);
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
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