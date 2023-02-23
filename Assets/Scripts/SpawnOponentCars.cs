using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOponentCars : MonoBehaviour
{
    public GameObject spawnPrefab;      // prefab to spawn
    public float spawnInterval = 3.0f;  // interval of times in seconds between spawns
    public float spawnDelay = 1.0f;     // initial delay before the first spawn

    private float spawnTimer = 0.0f;

    void Start()
    {
        spawnTimer = spawnInterval - spawnDelay;
    }

    // If the time has elapsed, reset the timer and spawn a car
    void Update()
    {
        spawnTimer += Time.deltaTime; 
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0.0f;

            Instantiate(spawnPrefab, transform.position, transform.rotation);
        }
    }
}
