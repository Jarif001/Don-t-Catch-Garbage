using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBas1 : MonoBehaviour
{
    public Transform Basket1;
    public Vector3 distance;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Basket1.position + distance;
    }
}
