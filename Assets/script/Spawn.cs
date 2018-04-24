using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public Transform kegs;
    public int numToSpawn;
    public Vector3 position;
    public float spawnTime;
    public GameObject player;

    void Update()
    {
        
    }

    void Start()
    {

        InvokeRepeating("SpawnK", spawnTime, spawnTime);

    }


    void SpawnK()
    {
        int spawned = 0;
        while (spawned < numToSpawn)
        {
            Vector3 position = new Vector3(Random.Range(12.0F, ((player.transform.position.x) + 60f)), 17, 1);
            spawned++;
            Instantiate(kegs, position, Quaternion.identity);
        }
    }
}
