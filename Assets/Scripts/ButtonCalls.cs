using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCalls : MonoBehaviour
{
    /// <summary>
    /// Workaround class to call Singleton functions from UI
    /// There must be a better way ...
    /// </summary>
    public void CallStartGame()
    {
        IGameManager.Instance.StartGame();
    }

    public void CallGameOver()
    {
        IGameManager.Instance.GameOver();
    }

    public void CallCloseApplication()
    {
        Application.Quit();
    }

    public void CallMainMenu()
    {
        IGameManager.Instance.MainMenu();
    }

    public void CallPauseMenu()
    {
        IGameManager.Instance.PauseMenu();
    }

}
