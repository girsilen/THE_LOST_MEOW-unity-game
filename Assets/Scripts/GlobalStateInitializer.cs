using UnityEngine;

public class GlobalStateInitializer : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    void Start()
    {
        glb.button1 = button1;
        glb.button2 = button2;
        glb.button3 = button3;

        if (glb.button1 != null) glb.button1.SetActive(false);
        if (glb.button2 != null) glb.button2.SetActive(false);
        if (glb.button3 != null) glb.button3.SetActive(false);
    }
}
