using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coincounter : MonoBehaviour {
    public float count, repeat;
    public bool reset;
    public Slider coinbar;
    public float tmpCount;
    // Use this for initialization
    void Start () {
        
        count = 0;
        coinbar.value = 0;
        reset = false;
        InvokeRepeating("SliderDecrease", repeat, repeat);



    }
	
	// Update is called once per frame
	void Update () {

        //coinbar.value = count;
        //StartCoroutine(SliderDecrease(coinbar));
        if (coinbar.value > 9.5)
            CancelInvoke();

    }

    void SliderDecrease()
    {
        if(coinbar.value>0)
            coinbar.value -= 0.2f;
        
        
    }
 
    }
   

