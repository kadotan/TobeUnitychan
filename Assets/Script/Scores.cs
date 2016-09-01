using UnityEngine;
using System.Collections;
using System;

public class Scores : MonoBehaviour
{

    public GUIText scoreText;
    public static int score;


    // Use this for initialization
    void Start()
    {
        score = 0;
        UpdateScore();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }



    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

}
