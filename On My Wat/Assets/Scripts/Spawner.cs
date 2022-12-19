using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject auto;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;

    public int numero;

    void Start()
    {
        int n = (numero - 1) * 2;
        spawnTime = PlayerPrefs.GetFloat("save" + (n  + 1),spawnTime);
        spawnDelay = PlayerPrefs.GetFloat("save" +(n + 2),spawnDelay);
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
