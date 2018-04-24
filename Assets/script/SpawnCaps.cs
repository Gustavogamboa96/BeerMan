using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaps : MonoBehaviour
{
    public Transform kegs;
    public GameObject cap;
    public int numToSpawn;
    public Vector3 position;
    public float spawnTime;
    public GameObject player;

    void Update()
    {
       
    }

    void Start()
    {

        cap = GameObject.Find("cap");
        InvokeRepeating("SpawnK", spawnTime, Random.Range(1.0f, 2.0f));

    }




    void SpawnK()
    {
        int spawned = 0;
        while (spawned < numToSpawn)
        {
            Vector3 position = new Vector3(Random.Range(12.0F, ((player.transform.position.x) + 25f)), Random.Range(6.6f, 1.2f), 1);
            spawned++;
            Instantiate(kegs, position, Quaternion.identity);
            if (!cap.activeSelf)
            {
                cap.SetActive(true);
            }
        }
    }
}
