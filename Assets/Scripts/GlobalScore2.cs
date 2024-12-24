using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using TMPro;

public class GlobalScore2 : MonoBehaviour
{

    public GameObject healthbar;
    public static int currenthealth;    // the score 
    public int internalhealth;  // what we see

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //GlobalScore.currenthealth += 100;
        internalhealth = currenthealth;
        healthbar.GetComponent<Text>().text = "" + internalhealth;
        if (currenthealth < 0) 
        {
            LoadCurrentScene();
        }

    void LoadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }


    }
}
