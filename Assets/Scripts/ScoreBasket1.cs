using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBasket1 : MonoBehaviour
{
    int score1;
    public Text score1Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "coin") {
            scoreUpdate();
        }
        if (coll.gameObject.tag == "garbage")
        {
            GameManager.instance.GameOver();
            GameManager.instance.garbageOver();
        }
    }
    public void scoreUpdate() {
        score1++;
        score1Text.text = score1.ToString();
    }
}
