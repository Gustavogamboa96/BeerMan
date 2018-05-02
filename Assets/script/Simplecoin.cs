using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simplecoin : MonoBehaviour
{
    
    //AudioClip clip;
    // public AudioSource audioSource;
    ///GameObject sound;
    public coincounter coincounter;
    
    Text score;

    private void Start()
    {
        //reset = false;
         //audioSource = GetComponent<AudioSource>();
        //listen = GetComponent<AudioListener>();
    }
    private void Awake()
    {
        coincounter = GameObject.Find("Counter").GetComponent<coincounter>();
        score = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        //audioSource.PlayClipAtPoint(clip, transform.position);
        //audioSource.Play();
        if (player.gameObject.name == "1")
        {
            coincounter.coinbar.value += 1f;
            //print(coincounter.count);
            score.text = "x" + coincounter.coinbar.value;
            // audioSource.Play();
            //Destroy(gameObject);
            gameObject.SetActive(false);    
        //coincounter.reset = true;
        }
    }

}
