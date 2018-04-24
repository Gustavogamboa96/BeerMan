﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class killbox : MonoBehaviour {
    public ElPlayer mPlayer;
    public AudioSource audioS;
    public Canvas canvas, canvastmp;
    public GameObject exit;

    //public AssetBundle myLoadedAssetBundle;
   // public coincounter coin;
    //public GameObject testPrefab;
    // Use this for initialization
    void Start () {
        mPlayer = GameObject.Find("MusicPlayer").GetComponent<ElPlayer>();
        audioS = mPlayer.GetComponent<AudioSource>();
        //Scene newScene = SceneManager.CreateScene("Spawn");
        //myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        //testPrefab = (GameObject)Resources.Load("/sprites/coinsss");

    }

    
    void OnTriggerEnter2D(Collider2D player)
    {
        //print("collided");
        
        if (player.gameObject.name == "1")
       {
            
            canvas.enabled = false;
            exit.SetActive(true);
            audioS.Stop();
            Time.timeScale = 0;

           
            
      }
     
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //canvastmp.enabled = false ;
        //Time.timeScale = 1.0f;
    }
}
