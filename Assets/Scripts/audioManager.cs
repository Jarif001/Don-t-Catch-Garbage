using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static AudioClip coinSound;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("Collision");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip) {
        switch (clip) {
            case "Collision":
                audioSrc.PlayOneShot(coinSound);
                break;
        }
    }
}
