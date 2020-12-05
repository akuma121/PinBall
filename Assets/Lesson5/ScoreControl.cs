using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    private GameObject ScoreText;
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            Score += 10;
        }

        else if(other.gameObject.tag == "LageStarTag")
        {
            Score += 20;
        }

        else if(other.gameObject.tag == "SmallCloudTag")
        {
            Score += 25;
        }

        else if(other.gameObject.tag == "LageCloudTag")
        {
            Score += 50;
        }

        this.ScoreText.GetComponent<Text>().text = Score + "point";
    }

   
}
