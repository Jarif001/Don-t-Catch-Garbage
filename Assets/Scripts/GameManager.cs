using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public static GameManager instance;
    int score;
    public Text scoreText;
    public GameObject lastScore;
    public GameObject GameOverSound;
    public GameObject fartSound;
    public GameObject gameSound;
    public Text highScore;
    public GameObject highScorestuffs;
    public GameObject GarbageText;
    public GameObject TimePanel;
    public GameObject timeText;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void GameOver()
    {
        GameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        lastScore.SetActive(true);
        GameOverSound.SetActive(true);
        fartSound.SetActive(false);
        gameSound.SetActive(false);
        highScorestuffs.SetActive(true);

    }
    public void TimeOver()
    {
        TimePanel.SetActive(true);
        Time.timeScale = 0f;
        lastScore.SetActive(true);
        GameOverSound.SetActive(true);
        fartSound.SetActive(false);
        gameSound.SetActive(false);
        highScorestuffs.SetActive(true);
        timeText.SetActive(false);
    }
    public void ScoreUpdate()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();

        }
    }
    public void garbageOver()
    {
        GarbageText.SetActive(true);
    }
    public void reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }


}
