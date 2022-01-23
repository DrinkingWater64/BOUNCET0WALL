using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;

    public float points = 0;
    public float speed = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 60)
        {
            speed += Time.deltaTime * .1f;
        }
    }

    public void endGame()
    {
        SceneManager.LoadScene("GameOver");
        resetGame();
    }

    public void replay()
    {
        SceneManager.LoadScene("gamescene");
    }

    public void resetGame()
    {
        points = 0;
        speed = 1;
    }

    public void reverseWorld()
    {
        speed = speed * (-1.0f);
    }

    public void boostSpeed()
    {
        speed = speed * 1.5f;
    }

    public void resetSpeed()
    {
        speed = speed / 1.5f;
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
