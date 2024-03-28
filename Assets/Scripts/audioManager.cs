using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static AudioClip coinSound;
    public static AudioClip garbageSound;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("Collision");
        garbageSound = Resources.Load<AudioClip>("garbages");
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
            case "garbages":
                audioSrc.PlayOneShot(garbageSound);
                break;
        }
    }
}
