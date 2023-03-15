 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] animalPrefrabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Randomly generate animal index and spawn position 
            int animalIndex = Random.Range(0, animalPrefrabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefrabs[animalIndex], spawnPos, animalPrefrabs[animalIndex].transform.rotation);
        }
    }
}
