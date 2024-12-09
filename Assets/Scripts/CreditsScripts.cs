using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScripts : MonoBehaviour
{
    public GameObject Anim;
    public GameObject clickBtn;

    public void BackBtn() {
        SceneManager.LoadScene("Menu");
    }
    public void ClickBtn() {
        Anim.SetActive(true);
        clickBtn.SetActive(false);
    }
}
