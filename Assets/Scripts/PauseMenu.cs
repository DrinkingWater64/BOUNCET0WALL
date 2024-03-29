using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static event Action<PauseMenu> onTutorial;

    public GameObject pauseMenu;
    public GameObject button;
    public GameObject pauseButton;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        if (PlayerPrefs.GetString("TutorialStatus") == "false")
        {
            Player.onTutorial += handleButtonInteraction;
            pauseButton.GetComponent<Button>().enabled = false;

        }
        else
        {
            pauseButton.GetComponent<Button>().enabled = true;

        }
    }

    private void handleButtonInteraction(Player obj)
    {
        pauseButton.GetComponent<Button>().enabled = true;
        Player.onTutorial -= handleButtonInteraction;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pauseGame()
    {
        if (isPaused == false)
        {
            isPaused = true;
            Debug.Log("kire baal");
            Time.timeScale = 0;
            button.SetActive(false);
            pauseMenu.SetActive(true);

            if (onTutorial != null)
            {
                onTutorial(this);
            }
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            isPaused = false;
            button.SetActive(true);
            if (onTutorial != null)
            {
                onTutorial(this);
            }
        }
    }

}
