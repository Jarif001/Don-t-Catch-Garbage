using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CspawnDouble : MonoBehaviour
{
    public float maxPos = 5.5f;
    public GameObject Coin;
    public float delay = 1.5f;
    float timer;
    float delaySpeed = 100f;

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
            Vector3 spawnPos = new Vector3(Random.Range(-5.5f, 5.5f), transform.position.y, transform.position.z);
            Instantiate(Coin, spawnPos, transform.rotation);
            timer = delay;
        }

        if (delaySpeed >= 80)
        {
            delay = 1.5f;
        }
        else if (delaySpeed >= 50)
        {
            delay = 1f;
        }
        else if (delaySpeed >= -5)
        {
            delay = 0.5f;
        }
        else
        {
            delay = 0.3f;
        }

    }
}
