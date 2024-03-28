using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addOnsBehaviour : MonoBehaviour
{
    GameObject basket;

    // Start is called before the first frame update
    void Start()
    {
        basket = GameObject.FindWithTag("basket");
        //basketScript = basket.GetComponent<ScoreTime>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "basket")
        {
            audioManager.PlaySound("Collision");
            Destroy(gameObject);         
        }
        if (col.gameObject.tag == "land")
        {
            Destroy(gameObject);
        }
    }
}
