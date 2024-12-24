using System.Collections;
using UnityEngine;

public class WallTooHigh : MonoBehaviour
{
    public GameObject soundo;
    public GameObject uiObjecto;

    void Start()
    {
        soundo.SetActive(false);
        uiObjecto.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            soundo.SetActive(true);
            uiObjecto.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(7);
        Destroy(uiObjecto);
        Destroy(gameObject);
    }
}
