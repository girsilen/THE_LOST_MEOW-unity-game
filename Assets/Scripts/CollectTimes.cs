using UnityEngine;

public class CollectTimes : MonoBehaviour
{
    public GameObject soundd;

    void Start()
    {
        soundd.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GlobalTimer globalTimer = FindObjectOfType<GlobalTimer>(); 
            if (globalTimer != null)
            {
                globalTimer.AddSeconds(120); 
            }
            
            soundd.SetActive(true); // Activate sound effect
            Invoke("DestroyTimeBooster", 0.5f); 
        }
    }

    private void DestroyTimeBooster()
    {
        Destroy(gameObject);
    }
}
