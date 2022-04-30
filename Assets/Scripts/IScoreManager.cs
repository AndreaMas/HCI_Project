using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IScoreManager : MonoBehaviour
{
    public static IScoreManager Instance { get; private set; }
    private int score;
    private int highScore;

    public Text scoreInGame;
    public Text scoreGameOver;
    public Text highScoreGameOver;


    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        ResetScore();
        highScore = PlayerPrefs.GetInt("highScore");
        
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreInGame.text = score.ToString();
    }

    public void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", highScore);
        }
        scoreInGame.text = score.ToString();
        scoreGameOver.text = score.ToString();
        highScoreGameOver.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highScore");
    }
}
