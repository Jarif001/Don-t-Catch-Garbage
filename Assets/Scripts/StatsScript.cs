using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatsScript : MonoBehaviour
{
    public Text sinText;
    public Text doubText;
    public Text timeText;

    //enable disable

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    public GameObject object7;
    public GameObject object8;
    public GameObject object9;
    public GameObject object10;
    public GameObject object11;
    public GameObject object12;

    // Start is called before the first frame update
    void Start()
    {
        sinText.text = PlayerPrefs.GetInt("HighScoreSin").ToString();
        doubText.text = PlayerPrefs.GetInt("HighScoreDoub").ToString();
        timeText.text = PlayerPrefs.GetInt("HighScoreTime").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backBtn() {
        SceneManager.LoadScene("Menu");
    }
    public void yesAll() {
        PlayerPrefs.DeleteAll();
        sinText.text = 0.ToString();
        doubText.text = 0.ToString();
        timeText.text = 0.ToString();
        object1.SetActive(true);
        object2.SetActive(true);
        object3.SetActive(true);
        object4.SetActive(true);
        object5.SetActive(true);
        object6.SetActive(true);
        object7.SetActive(true);
        object8.SetActive(true);
        object9.SetActive(true);
        object10.SetActive(false);
        object11.SetActive(false);
        object12.SetActive(false);
    }
    public void resetBtn() {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
        object5.SetActive(false);
        object6.SetActive(false);
        object7.SetActive(false);
        object8.SetActive(false);
        object9.SetActive(false);
        object10.SetActive(true);
        object11.SetActive(true);
        object12.SetActive(true);
    }
    public void noBtn() {
        object1.SetActive(true);
        object2.SetActive(true);
        object3.SetActive(true);
        object4.SetActive(true);
        object5.SetActive(true);
        object6.SetActive(true);
        object7.SetActive(true);
        object8.SetActive(true);
        object9.SetActive(true);
        object10.SetActive(false);
        object11.SetActive(false);
        object12.SetActive(false);
    }
}
