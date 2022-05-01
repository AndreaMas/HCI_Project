using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameManager : MonoBehaviour
{
    public static IGameManager Instance { get; private set; }
    public EggSpawner eggSpawner;
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
        eggSpawner.StartEggDrop();
    }

    public void GameOver()
    {
        IScoreManager.Instance.UpdateHighScore();
        mainCamera.transform.Rotate(Vector3.left, -90);
        uiManager.ShowGameOverUI();
        eggSpawner.StopEggDrop();
        eggSpawner.DestroyAllEggs();
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
