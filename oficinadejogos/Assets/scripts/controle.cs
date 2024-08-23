using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class controle : MonoBehaviour
{
    public int totalScore;
    public static controle instance;
    public TextMeshProUGUI scoreText;
    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGamerOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string nivel2)
    {
        SceneManager.LoadScene(nivel2);
    }
}

