using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawnDoub : MonoBehaviour
{
    public GameObject garbage;
    public float maxPos = 5.5f;
    public float delay = 3f;
    float timer;
    float delaySpeed = 100f;
    public GameObject speedText0;
    public GameObject speedText1;
    public GameObject speedText2;
    public GameObject speedText3;
    public GameObject speedText4;


    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        delaySpeed -= Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 gPos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
            Instantiate(garbage, gPos, transform.rotation);
            timer = delay;
        }
        if (delaySpeed >= 80)
        {
            delay = 3f;
            speedText0.SetActive(true);
        }
        else if (delaySpeed >= 50)
        {
            delay = 2f;
            speedText1.SetActive(true);
            speedText0.SetActive(false);
        }
        else if (delaySpeed >= -5)
        {
            delay = 1f;
            speedText2.SetActive(true);
            speedText1.SetActive(false);
        }
        else if (delaySpeed >= -80)
        {
            delay = 0.5f;
            speedText3.SetActive(true);
            speedText2.SetActive(false);
        }
        else
        {
            delay = 0.3f;
            speedText4.SetActive(true);
            speedText3.SetActive(false);
        }
    }
}
