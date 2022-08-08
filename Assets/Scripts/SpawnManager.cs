/*
 * Spawns good and bad food from 
 * the top of the screen within xValue
 * range, at a locked y value.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;

    private float yValue = 6f;
    private float xValueRange = 8f;

    private float spawnDelay = 2;
    private float spawnInterval = .5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFood", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomFood()
    {
        int index = Random.Range(0, foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xValueRange, xValueRange), yValue, 0);

        Instantiate(foodPrefabs[index], spawnPos, foodPrefabs[index].transform.rotation);
    }
}
