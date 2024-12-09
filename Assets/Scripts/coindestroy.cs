using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coindestroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "basket")
        {
            GameManager.instance.ScoreUpdate();
            audioManager.PlaySound("Collision");
            Destroy(gameObject);

        }
        if (col.gameObject.tag == "land")
        {
            Destroy(gameObject);
        }
    }
}
