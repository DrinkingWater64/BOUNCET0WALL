using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    private void Update()
    {
        score.text = GameManager.instance.points.ToString();
    }
}
