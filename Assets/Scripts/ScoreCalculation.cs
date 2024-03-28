using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculation : MonoBehaviour
{
    //Double baskets
    public Text score1;
    public Text score2;
    int score;
    public Text scoreText;
    public Text highScoreText;
    public GameObject highSound;

    //time for highText
    float timeHighText = 0;
    public GameObject highText;
    bool startTime = false;
    bool resetPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScoreDoub").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = int.Parse(score1.text) + int.Parse(score2.text);
        scoreText.text = score.ToString();
        if (!resetPressed) { 
            if (score > PlayerPrefs.GetInt("HighScoreDoub",0)) {
                PlayerPrefs.SetInt("HighScoreDoub",score);
                highScoreText.text = score.ToString();
                highSound.SetActive(true);
                startTime = true;
            }
        }
        if (startTime) { 
            timeHighText += Time.deltaTime;
            if (timeHighText > 0)
            {
                highText.SetActive(true);
            }
            if (timeHighText > 2)
            {
                highText.SetActive(false);
            }
        }
    }
    public void resetScoreDoub()
    {
        highScoreText.text = 0.ToString();
        PlayerPrefs.DeleteKey("HighScoreDoub");
        resetPressed = true;
    }
}
