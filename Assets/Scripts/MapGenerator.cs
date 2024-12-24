using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] flowerPrefabs;
    [SerializeField] private Transform[] spawnLocations;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Generate();
        }
    }

    private void Generate()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            // Destroy existing child object if any
            if (spawnLocations[i].childCount > 0)
            {
                for (int j = spawnLocations[i].childCount - 1; j >= 0; j--)
                {
                    Destroy(spawnLocations[i].GetChild(j).gameObject);
                }
            }

            // Generate random index
            int randomIndex = Random.Range(0, flowerPrefabs.Length);

            // Instantiate the flower prefab
            GameObject flower = Instantiate(flowerPrefabs[randomIndex], spawnLocations[i].position, flowerPrefabs[randomIndex].transform.rotation);

            // Set the flower's parent to the spawn location
            flower.transform.SetParent(spawnLocations[i]);
        }
    }
}
