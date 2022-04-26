using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
    void Start()
    {
        AudioManager.instance.playMusic(clip);    
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
