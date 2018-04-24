using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    //public GameObject player;
    public ElPlayer este;
    public AudioSource aquel, win;
	// Use this for initialization
	void Start () {
        este = GameObject.Find("MusicPlayer").GetComponent<ElPlayer>();
        aquel = este.GetComponent<AudioSource>();
        win = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "1")
        {

            Time.timeScale = 0;
            aquel.volume = 0f;
            win.Play();
        }


    }

    }

