using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
    public bool onStart = false;
    void Start()
    {
        if (onStart)
        {
            playSFX();
        }
    }

    public void playSFX()
    {
        AudioManager.instance.playSFX(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
