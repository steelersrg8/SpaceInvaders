using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public static int score = 0;

    void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(20, 20, 80, 40), "Score: " + score);
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
