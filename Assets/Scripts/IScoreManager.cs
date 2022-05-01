using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IScoreManager : MonoBehaviour
{
    public static IScoreManager Instance { get; private set; }
    private int score;

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
            PlayerPrefs.SetInt("highScore", score);
        }
        scoreInGame.text = score.ToString();
        scoreGameOver.text = score.ToString();
        highScoreGameOver.text = PlayerPrefs.GetInt("highScore").ToString();
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
