using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

    public static event Action<Player> onTutorial;

    public float force;
    public Rigidbody2D rb;
    public Sprite whiteball;
    public Sprite blackball;
    public bool canGoRight = false;
    public bool canGoLeft = false;
    private bool canControl = true;
    private SpriteRenderer renderer_;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        renderer_ = gameObject.GetComponent<SpriteRenderer>();
        renderer_.sprite = whiteball;
    }

    private void Update()
    {
        jump();
       
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameManager.instance.boostSpeed();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GameManager.instance.resetSpeed();
        }
    }

    public void jump()
    {
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            int id = touch.fingerId;
            if (!EventSystem.current.IsPointerOverGameObject(id) && canControl)
            //{
                if (canGoRight)
                    goRight();
                if (canGoLeft)
                    goLeft();
            //}
        }*/
    }

    private void goRight()
    {
        rb.velocity = Vector2.right * force;
        canGoRight = false;
    }
    private void goLeft()
    {
        rb.velocity = Vector2.left * force;
        canGoLeft = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Right")
        {
            transform.SetParent(collision.transform.parent);
            canGoRight = true;
        }
        if (collision.gameObject.name == "Left")
        {
            transform.SetParent(collision.transform.parent);
            canGoLeft = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Right")
        {
            transform.SetParent(collision.transform.parent);
        }
        if (collision.gameObject.name == "Left")
        {
            transform.SetParent(collision.transform.parent);
        }
        if(collision.gameObject.name == "Black")
        {
            renderer_.sprite = whiteball;
        }
        if (collision.gameObject.name == "White")
        {
            renderer_.sprite = blackball;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Right")
        {
            transform.SetParent(null);
            canGoLeft = false;
            canGoRight = false;
        }
        if (collision.gameObject.name == "Left")
        {
            transform.SetParent(null);
            canGoLeft = false;
            canGoRight = false;
        }
        if (collision.gameObject.name == "GameOverArea")
        {
            GameManager.instance.endGame();
        }
    }

    private void OnBecameInvisible()
    {
        canControl = false;
    }

    private void OnBecameVisible()
    {
        canControl = true;
    }

    public void testButton()
    {
        Debug.Log("button wroks");
        if (canGoRight)
            goRight();
        if (canGoLeft)
            goLeft();
                        
        if(onTutorial != null)
        {
            onTutorial(this);
        }
    }

}
