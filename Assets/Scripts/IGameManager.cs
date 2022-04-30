using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameManager : MonoBehaviour
{
    public static IGameManager Instance { get; private set; }
    // ... reference to egg spawner
    public GameObject mainCamera;
    public UIManager uiManager;

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
    }


    public void StartGame()
    {
        IScoreManager.Instance.ResetScore();
        ILivesManager.Instance.ResetLife();
        mainCamera.transform.Rotate(Vector3.left, 90);
        uiManager.ShowGameUI();

        // ... tell egg spawner to spawn eggs
    }

    public void GameOver()
    {
        IScoreManager.Instance.UpdateHighScore();
        mainCamera.transform.Rotate(Vector3.left, -90);
        uiManager.ShowGameOverUI();

        // ... stop egg spawner

        // tell egg spawner to destroy all eggs
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Egg");
        foreach (GameObject enemy in enemies)
        GameObject.Destroy(enemy);
    }

    public void MainMenu()
    {
        uiManager.ShowMainMenuUI();
    }

    public void PauseMenu()
    {
        uiManager.ShowPauseUI();
    }

}
