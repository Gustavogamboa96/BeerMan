using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTmp : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("1");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = transform.position;
        float dist = (currentPosition.x - player.transform.position.x);
        //print(dist);
        if (dist  <  -15)
        {
            
            gameObject.SetActive(false);
        }
	}
}
