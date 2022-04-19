using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    public TextMeshProUGUI highscore;
    public float hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = PlayerPrefs.GetFloat("highscore");
        if( hs > 0)
        {
            highscore.text = hs.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
