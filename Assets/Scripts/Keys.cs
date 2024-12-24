using UnityEngine;

public class Keys : MonoBehaviour
{
    public GameObject key; 
    public GameObject door;
    public GameObject soundo;
    public GameObject keyPhoto;

    void Start() 
    {
        soundo.SetActive(false);
        keyPhoto.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set static variable 'open' in script FinishLevel to 1
            FinishLevel.open = 1;

            // Destroy the collected key GameObject
            Destroy(key);

            // Destroy the door
            Destroy(door);
            
            // Sound of key picking
            soundo.SetActive(true);

            // Key on top of the screen 
            keyPhoto.SetActive(true);
        }
    }
}
