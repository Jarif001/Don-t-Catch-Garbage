﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "land") {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "basket")
        {
            audioManager.PlaySound("garbages");
            Destroy(gameObject);
        }
    }
}