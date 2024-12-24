using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;


    public void PLAY()
    {
        buttonPress.Play();
        //RedirectToLevel.redirectToLevel = 0;
        SceneManager.LoadScene(1);

    }

    public void QUIT() 
    {
        Application.Quit();
    }

    public void CREDITS()
    {
        SceneManager.LoadScene(5);
    }

    public void HOW()
    {
        SceneManager.LoadScene(8);
    }

    public void BACKTOMAIN()
    {
        SceneManager.LoadScene(0);
    }
}
