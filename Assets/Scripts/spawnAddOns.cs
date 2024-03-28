using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAddOns : MonoBehaviour
{

    public GameObject addOnsPrefab;
    public Sprite[] addOnsSprites;

    float timeAddOns = 0f;//20 secs por por je ashbe
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAddOns += Time.deltaTime;
        if (timeAddOns >= 16) {
            randomAddOns();
            timeAddOns = 0;
        }
    }

    public void randomAddOns() {
        int randIdx = Random.Range(0, addOnsSprites.Length);
        Sprite addOnsSprite = addOnsSprites[randIdx];

        Vector3 spawnPos = new Vector3(Random.Range(-5.5f, 5.5f), transform.position.y, transform.position.z);
        Instantiate(addOnsPrefab, spawnPos, transform.rotation);
        addOnsPrefab.GetComponent<SpriteRenderer>().sprite = addOnsSprite;
        addOnsPrefab.name = addOnsSprite.name;
    }
}
