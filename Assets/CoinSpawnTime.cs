using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public float maxPos = 5.5f;
    public GameObject Coin;
    public float delay = 1.5f;
    float timer;
    float delaySpeed = 75f;

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

        if (delaySpeed >= 60)
        {
            delay = 1.5f;
        }
        else if (delaySpeed >= 45)
        {
            delay = 1f;
        }
        else if (delaySpeed >= 30)
        {
            delay = 0.5f;
        }
        else if (delaySpeed >= 15)
        {
            delay = 0.3f;
        }
        else
        {
            delay = 0.2f;
        }
    }
}
