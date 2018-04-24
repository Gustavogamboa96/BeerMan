using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
       // UnityEngine.UI.Button start = GameObject.Find("Start_b").GetComponent<UnityEngine.UI.Button>();
    }

    public void resume()
    {
        Time.timeScale = 1.0f;
    }
}
