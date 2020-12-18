using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int score = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Text").GetComponent<Text>();
        this.textComponent.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("score", score);
    }

    public void AddScore()
    {
        this.score += 300;
        this.textComponent.text =  score.ToString();
    }

    public void AddScore1()
    {
        this.score += 1;
        this.textComponent.text = score.ToString();
    }

}