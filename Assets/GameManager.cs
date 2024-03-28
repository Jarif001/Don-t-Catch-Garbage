using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public static GameManager instance;
    public GameObject lastScore;
    public GameObject GameOverSound;
    public GameObject fartSound;
    public GameObject gameSound;
    public GameObject highScorestuffs;
    public GameObject GarbageText;
    public GameObject TimePanel;
    public GameObject timeText;
    public GameObject scoreDoub;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       
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
        scoreDoub.SetActive(true);
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

    public void garbageOver()
    {
        GarbageText.SetActive(true);
    }

}
