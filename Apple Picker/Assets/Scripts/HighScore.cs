using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int score = 1000;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", score);
    }
    // Update is called once per frame
    void Update()
    {
        Text gt= GetComponent<Text>();
        gt.text = "High score: "+ score;
        if(score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
    }
}
