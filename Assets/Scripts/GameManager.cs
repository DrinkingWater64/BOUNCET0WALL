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
    public float highscore = 0;
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
            speed += Time.deltaTime * .2f;
        }

        setHighScore();
    }

    public void endGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void replay()
    {
        resetGame();
        SceneManager.LoadScene("gamescene");
    }

    public void gotoMainScene()
    {
        resetGame();
        SceneManager.LoadScene("StartScene");
    }

    public void resetGame()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        instance.points = 0;
        instance.speed = 1;
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

    public void setHighScore() 
    {
        if (points > highscore)
        {
            highscore = points;
            PlayerPrefs.SetFloat("highscore", highscore);
        }
    }

    public void getHighScore()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetFloat("highscore");
        }
    }

}
