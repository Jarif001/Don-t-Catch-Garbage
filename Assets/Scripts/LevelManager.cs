using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] lvlButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        int lvlAt = PlayerPrefs.GetInt("lvlAt" , 2);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > lvlAt)
            {
                lvlButtons[i].interactable = false;
            }
        }
        if (PlayerPrefs.GetInt("HighScoreSin") > -1)
        {
            PlayerPrefs.SetInt("lvlAt", 3);
        }
        if (PlayerPrefs.GetInt("HighScoreDoub") >= 0)
        {
            PlayerPrefs.SetInt("lvlAt", 4);
        }

    }

    void Update() {
       
        
    }
   
}
