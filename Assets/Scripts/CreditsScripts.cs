using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScripts : MonoBehaviour
{
    public GameObject textGrp;
    public GameObject textAnim;
    public GameObject clickBtn;

    public void BackBtn() {
        SceneManager.LoadScene("Menu");
    }
    public void ClickBtn() {
        textAnim.SetActive(false);
        textGrp.SetActive(true);
        clickBtn.SetActive(false);
    }
}
