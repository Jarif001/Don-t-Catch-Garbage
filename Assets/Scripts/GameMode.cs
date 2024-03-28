using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public GameObject SinInfoStuff;
    public GameObject DouInfoStuff;
    public GameObject TimeInfoStuff;
    public GameObject Buttons;
    public GameObject texts;

    public void singleBasket() {
        SceneManager.LoadScene("Level01");
    }
    public void doubleBasket()
    {
        SceneManager.LoadScene("Level02");
    }
    public void timeMode() {
        SceneManager.LoadScene("Level03");
    }
    public void SinInfo() {
        SinInfoStuff.SetActive(true);
        Buttons.SetActive(false);
        texts.SetActive(false);
    }
    public void SinInfoBack()
    {
        SinInfoStuff.SetActive(false);
        Buttons.SetActive(true);
        texts.SetActive(true);
    }
    public void DouInfo()
    {
        DouInfoStuff.SetActive(true);
        Buttons.SetActive(false);
        texts.SetActive(false);
    }
    public void DouInfoBack()
    {
        DouInfoStuff.SetActive(false);
        Buttons.SetActive(true);
        texts.SetActive(true);
    }
    public void timeInfo() {
        TimeInfoStuff.SetActive(true);
        Buttons.SetActive(false);
        texts.SetActive(false);
    }
    public void timeInfoBack() {
        TimeInfoStuff.SetActive(false);
        Buttons.SetActive(true);
        texts.SetActive(true);
    }
    public void quitGame() {
        Application.Quit();
    }
    public void menuBtn() {
        SceneManager.LoadScene("Menu");
    }
}
