using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuu;
    public GameObject GameOverMenu;
    public GameObject fartSound;
    public GameObject gameSound;
    bool GameIsPaused;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();
            }
        }
    }
    
    
    public void Resume() {
        Time.timeScale = 1f;
        PauseMenuu.SetActive(false);
        GameOverMenu.SetActive(false);
        GameIsPaused = false;
    }
    public void Pause() {
        Time.timeScale = 0f;
        PauseMenuu.SetActive(true);
        GameIsPaused = true;
    }

    public void Menu() {
        SceneManager.LoadScene("Menu");
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void fartSoundOn() {
        fartSound.SetActive(true);
    }
    public void fartSoundOff()
    {
        fartSound.SetActive(false);
    }
    public void GameSoundOn()
    {
        gameSound.SetActive(true);
    }
    public void GameSoundOff()
    {
        gameSound.SetActive(false);
    }
}
