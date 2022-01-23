using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("pause");
                pauseGame();
                isPaused = true;
            }
        }
        else if (isPaused == true)
        {
            Debug.Log("return");
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("resume");
                exitPause();
                isPaused = false;
            }
        }


    }

    private void pauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    private void exitPause()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
