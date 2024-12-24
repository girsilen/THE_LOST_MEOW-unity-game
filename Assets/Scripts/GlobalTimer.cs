using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//using TMPro; 
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay1;
    public bool isTime = false;
    public int theSeconds = 150;

    // Update is called once per frame
    void Update()
    {
        if (isTime == false) 
        {
            StartCoroutine(SubtractSecond());
        } else if (theSeconds < 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator SubtractSecond() 
    {
        isTime = true;
        theSeconds -= 1;
        //timeDisplay1.GetComponent<TextMeshProUGUI>().text = theSeconds.ToString();
        timeDisplay1.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1); 
        isTime = false;
    }

    public void AddSeconds(int secondsToAdd)
    {
        theSeconds += secondsToAdd;
        UpdateTimeDisplay();
    }

    private void UpdateTimeDisplay()
    {
        // Update the UI text to display the current countdown value
        timeDisplay1.GetComponent<Text>().text = theSeconds.ToString();
    }
}
