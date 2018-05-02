using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGirl : MonoBehaviour
{
    public GameObject player;
   public float t, dist;
    public Vector3 startPosition;
    public Vector3 target, tmp, pos;
    public coincounter coincounter;
    
    
    public float timeToReachTarget;
    void Start()
    {
        coincounter = GameObject.Find("Counter").GetComponent<coincounter>();
        pos = player.transform.position;
        tmp.Set(-4, -0.68f, 0);
        startPosition = target = transform.position;
        
        //dist = Vector3.Distance(startPosition, pos);
    }
    void Update()
    {
       
        t += Time.deltaTime / timeToReachTarget;
        transform.position = Vector3.Lerp(startPosition, target, t);
        if (transform.position.x < (player.transform.position.x)-5)
        {
            //startPosition.Set(transform.position.x, -0.6855116f,0);
            if(coincounter.coinbar.value<5)
                SetDestination(((player.transform.position.x) +4.5f), Random.Range(1.2f, 1.4f));
            else
                SetDestination(((player.transform.position.x) + 4.5f), Random.Range(0.5f, 1.0f));

            //dist = Vector3.Distance(startPosition, pos);
        }
       // print(dist);
    }
    public void SetDestination(float destination, float time)
    {
        t = 0;
        startPosition.Set(transform.position.x, -0.6855116f, 0);
        timeToReachTarget = time;
        target.Set(destination, -0.6855116f, 0);
    }
    
}