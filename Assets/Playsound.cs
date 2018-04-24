using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour {
    AudioSource audio1;
    //AudioClip pop;

	// Use this for initialization
	void Start () {
        audio1 = GetComponent<AudioSource>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "caps(clone)" || collision.gameObject.name == "cap" )
            audio1.Play();    
    
    }
}
