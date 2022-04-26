using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update


    public static event Action<Point> onTutorial;
    public ParticleSystem particle;
    public SpriteRenderer renderer_;
    public bool once = true;
    public AudioClip clip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && once)
        {
            var em = particle.emission;
            var dur = particle.main.duration;
            em.enabled = true;
            particle.Play();
            AudioManager.instance.playSFX(clip);

            once = false;
            Destroy(renderer_);
            Debug.Log("hit");
            if(onTutorial != null)
            {
                onTutorial(this);
            }
            GameManager.instance.points += 5;
            Invoke("destroyObj", dur);
        }
    }

    private void destroyObj()
    {
            Destroy(gameObject);
    }
}
