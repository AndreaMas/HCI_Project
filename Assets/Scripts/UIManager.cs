using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelGame;
    public GameObject panelGameOver;
    public GameObject panelPause;
    public GameObject panelMainMenu;

    public void ShowGameUI()
    {
        panelGame.SetActive(true);
        panelGameOver.SetActive(false);
        panelPause.SetActive(false);
        panelMainMenu.SetActive(false);
    }

    public void ShowGameOverUI()
    {
        panelGame.SetActive(false);
        panelGameOver.SetActive(true);
        panelPause.SetActive(false);
        panelMainMenu.SetActive(false);
    }

    public void ShowPauseUI()
    {
        panelGame.SetActive(false);
        panelGameOver.SetActive(false);
        panelPause.SetActive(true);
        panelMainMenu.SetActive(false);
    }

    public void ShowMainMenuUI()
    {
        panelGame.SetActive(false);
        panelGameOver.SetActive(false);
        panelPause.SetActive(false);
        panelMainMenu.SetActive(true);
    }
}
