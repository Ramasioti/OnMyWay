using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject auto;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }


    public void SpawnObject()
    {
        Instantiate(auto, transform.position, transform.rotation);
        if (stopSpawing)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
