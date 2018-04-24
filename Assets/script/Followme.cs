using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followme: MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = target.transform.position.x + 10f;
       // position.y = target.transform.position.y;
        transform.position = position;
    }
}