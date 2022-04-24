using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{

    public GameObject bounce;
    public GameObject buttonText;

    // Start is called before the first frame update
    void Start()
    {
        bounce.SetActive(true);
        buttonText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBounceTextOff()
    {
        this.bounce.SetActive(false);
    }

    public void setButtonTextOff()
    {
        this.bounce.SetActive(false);
    }
}
