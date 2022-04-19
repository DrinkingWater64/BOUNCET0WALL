using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particle;
    public SpriteRenderer renderer_;
    public bool once = true;

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

            once = false;
            Destroy(renderer_);
            Debug.Log("hit");
            GameManager.instance.points += 5;
            Invoke("destroyObj", dur);
        }
    }

    private void destroyObj()
    {
            Destroy(gameObject);
    }
}
