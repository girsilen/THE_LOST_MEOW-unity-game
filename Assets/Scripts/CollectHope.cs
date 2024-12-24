using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class CollectHope : MonoBehaviour
{

    public GameObject HopeHealthbar;
    public GameObject soundd;

    void Start() 
    {
        soundd.SetActive(false);
    }

    void OnTriggerEnter() 
    {
        GlobalScore.currenthealth += 100;
         GlobalScore2.currenthealth += 100;
        soundd.SetActive(true);
        //HopeHealthbar.GetComponent<Text>().text = "100";
        Invoke("DestroyHopeBooster", 0.5f);
    }

    private void DestroyHopeBooster()
    {
        Destroy(gameObject);
    }
}
