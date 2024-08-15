using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class controle : MonoBehaviour
{
    public int totalScore;
    public static controle instance;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

}

