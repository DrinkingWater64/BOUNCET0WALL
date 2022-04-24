using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject bounceText;
    public GameObject pauseText1;
    public GameObject pauseText2;
    public GameObject pointText;
    // Start is called before the first frame update
    void Start()
    {
        

        if (PlayerPrefs.GetString("TutorialStatus") == "true")
        {
            bounceText.SetActive(false);
            pauseText1.SetActive(false);
            pauseText2.SetActive(false);
            pointText.SetActive(false);
        }
        else
        {
            Player.onTutorial += handleTapTutorial;
            PauseMenu.onTutorial += handlePauseTutorial;
            Point.onTutorial += pointTest;
            bounceText.SetActive(true);
            pauseText1.SetActive(false);
             pauseText2.SetActive(false);
            pointText.SetActive(false);
        }

    }

    private void pointTest(Point obj)
    {
        Debug.Log("points gained");
        pointText.SetActive(false);
        Point.onTutorial -= pointTest;
        setTutorialStatus();
    }

    private void handlePauseTutorial(PauseMenu obj)
    {
        Debug.Log("listened when tapped score");
        Debug.Log("listened when " + obj.isPaused);
        if(obj.isPaused == true)
        {
            pauseText1.SetActive(false);
            pauseText2.SetActive(true);
        }
        else
        {
            pauseText2.SetActive(false);
            pointText.SetActive(true);
            PauseMenu.onTutorial -= handlePauseTutorial;

        }
    }

    private void OnDestroy()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handleTapTutorial(Player player)
    {
        bounceText.SetActive(false);
        pauseText1.SetActive(true);
        Player.onTutorial -= handleTapTutorial;

    }

    public void setTutorialStatus()
    {
        PlayerPrefs.SetString("TutorialStatus", "true");
    }
}
