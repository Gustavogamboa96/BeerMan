using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
    // public bool UNITY_EDITOR { get; private set; }

    public void exitGame()
    {
        Application.Quit();
    }
}