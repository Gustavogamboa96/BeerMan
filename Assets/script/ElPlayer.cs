﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElPlayer : MonoBehaviour {

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            audioSource.mute = !audioSource.mute;
    }
}
