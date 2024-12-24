using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalScore : MonoBehaviour
{
    public GameObject healthbar;
    public static int currenthealth;    // the score 
    public int internalhealth;  // what we see

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = 100;  // Assuming starting health is 100
    }

    // Update is called once per frame
    void Update()
    {
        internalhealth = currenthealth;
        healthbar.GetComponent<Text>().text = internalhealth.ToString();
        if (currenthealth < 0) 
        {
            // Reload the current active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
