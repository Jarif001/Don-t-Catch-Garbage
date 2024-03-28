using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSin : MonoBehaviour
{
    int scoreSingle;
    public Text scoreTextSin;
    public Text highScoreSin;
    public GameObject highSound;
    public GameObject garbageText;
    public GameObject fellText;
    public GameObject rotText;
    public GameObject gameOverSound;
    public GameObject fartSound;
    public GameObject gameSound;
    public GameObject highScorestuffs;

    //time for highText
    float timeHighText = 0;
    public GameObject highText;
    bool yesHigh = false;

    // Start is called before the first frame update
    void Start()
    {
        highScoreSin.text = PlayerPrefs.GetInt("HighScoreSin").ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -4.5)
        {
            fellText.SetActive(true);
            gameOverSound.SetActive(true);
            fartSound.SetActive(false);
            gameSound.SetActive(false);
            highScorestuffs.SetActive(true);
        }
        if (transform.eulerAngles == Vector3.forward * 180)
        {
            rotText.SetActive(true);
            gameOverSound.SetActive(true);
            fartSound.SetActive(false);
            gameSound.SetActive(false);
            highScorestuffs.SetActive(true);
            GameManager.instance.GameOver();
        }
        if(yesHigh)
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
    public void scoreUpdateSin()
    {
        scoreSingle++;
        scoreTextSin.text = scoreSingle.ToString();
        if (scoreSingle > PlayerPrefs.GetInt("HighScoreSin", 0))
        {
            PlayerPrefs.SetInt("HighScoreSin", scoreSingle);
            highScoreSin.text = scoreSingle.ToString();
            highSound.SetActive(true);
            yesHigh = true;
        }
       
    }
    public void resetScoreSin() {
        PlayerPrefs.DeleteKey("HighScoreSin");
        highScoreSin.text = 0.ToString();
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "coin") {
            scoreUpdateSin();
        }
        if (coll.gameObject.tag == "garbage") {
            garbageText.SetActive(true);
            gameOverSound.SetActive(true);
            fartSound.SetActive(false);
            gameSound.SetActive(false);
            highScorestuffs.SetActive(true);
            GameManager.instance.GameOver();
            GameManager.instance.garbageOver();
        }
    }
}
