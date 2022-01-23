using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.replay();
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameManager.instance.quitGame();
        }
    }
}
