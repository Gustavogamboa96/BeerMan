using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class flooring : MonoBehaviour {
    public GameObject mySprite, player, mySprite2, beer;
    public coincounter coincounter;
    public Vector3 currentPosition, tmp, currentposition1;
    public Vector3 nextpos ;
    public float lifetime;
    public GameObject tmpObj1, tmpObj, tmpBeer; 
   // public GameObject[] arr;
    public Renderer myrend;
    public bool beerbool = true;

    // Use this for initialization
    void Start () {
        //floors = new GameObject[200];
        //this.GetComponent<SpriteRenderer>().sprite = mySprite;
        currentPosition = mySprite.transform.position;
        nextpos = player.transform.position;
        coincounter = GameObject.Find("Counter").GetComponent<coincounter>();
         
        for (int i = 0; i < 100; i++)
        {
            tmpObj = GameObject.Instantiate(mySprite, currentPosition, Quaternion.identity) as GameObject;
            currentPosition += new Vector3(1f, 0f, 0f);
           // arr[i] = tmpObj;
           tmpObj.AddComponent<floorTmp>();
        }
        

    }
    void Update()
    {
        
        float behind;
        float dist = Vector3.Distance(currentPosition, player.transform.position);
        //Debug.Log(dist);
        if (dist < 50)
        {
            if (coincounter.count < 5)
            {
                for (int i = 0; i < 50; i++)
                {
                    tmpObj1 = GameObject.Instantiate(mySprite, currentPosition, Quaternion.identity) as GameObject;
                    currentPosition += new Vector3(1f, 0f, 0f);
                    // tmp = tmpObj.transform.position;

                    behind = Vector3.Distance(player.transform.position, tmpObj1.transform.position);
                    //print(behind);


                    dist = Vector3.Distance(currentPosition, nextpos);
                    //Destroy(tmpObj1);
                }
            }
            else
            {
                for (int i = 0; i < 50; i++)
                {
                    tmpObj1 = GameObject.Instantiate(mySprite2, currentPosition, Quaternion.identity) as GameObject;
                    currentPosition += new Vector3(1f, 0f, 0f);
                    // tmp = tmpObj.transform.position;

                    behind = Vector3.Distance(player.transform.position, tmpObj1.transform.position);
                    //print(behind);


                    dist = Vector3.Distance(currentPosition, nextpos);
                }
            }

            //Destroy(mySprite, lifetime);
        }
        if (coincounter.count >= 10 && beerbool == true)
        {
            currentposition1 = currentPosition;
            currentposition1 += new Vector3(1f, 5f, 0f);
            Instantiate(beer, currentposition1, Quaternion.identity);
            beerbool = false;
        }

    }
    
}
	
