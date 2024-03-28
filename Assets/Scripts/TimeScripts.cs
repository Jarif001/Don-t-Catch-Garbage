using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScripts : MonoBehaviour
{
    public Text timeText;
    public float min;
    public float sec;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = min.ToString() + ":" + sec.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sec -= Time.deltaTime;
        timeText.text = min.ToString("0") + ":" + sec.ToString("0");
        if (sec < 0f) {
            min--;
            sec = 60f;
        }
        if (min < 0f)
        {
            timeText.text = "Time's Up";
            GameManager.instance.TimeOver();
        }

    }
}
