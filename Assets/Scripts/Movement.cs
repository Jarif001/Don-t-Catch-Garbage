using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sideSpeed;
    public float maxPos = 5.5f;
    public GameObject FellText;
    public GameObject RotText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                rb.velocity = Vector2.left * sideSpeed;
            }
            if (touchPos.x > 0)
            {
                rb.velocity = Vector2.right * sideSpeed;
            }
        }
        if (transform.position.y < -4.5)
        {
            GameManager.instance.GameOver();
            FellText.SetActive(true);
        }
        if (transform.eulerAngles == Vector3.forward * 180)
        {
            GameManager.instance.GameOver();
            RotText.SetActive(true);
        }

    }
}
