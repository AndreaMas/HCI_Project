using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ILivesManager : MonoBehaviour
{
    public static ILivesManager Instance { get; private set; }
    private int livesLeft;

    public RawImage life1;
    public RawImage life2;
    public RawImage life3;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        ResetLife();
    }

    public void ResetLife()
    {
        livesLeft = 3;
        DisplayLife();
    }

    public void RemoveLife()
    {
        livesLeft -= 1;
        if(livesLeft <= 0)
        {
            IGameManager.Instance.GameOver();
        }
        DisplayLife();
    }

    public void DisplayLife()
    {
        if (livesLeft == 3)
        {
            Debug.Log("3 LIVES LEFT");
            life1.color = new Vector4(255, 255, 255, 255); 
            life2.color = new Vector4(255, 255, 255, 255);
            life3.color = new Vector4(255, 255, 255, 255);
        }
        if (livesLeft == 2)
        {
            Debug.Log("2 LIVES LEFT");
            life1.color = new Vector4(255, 255, 255, 255);
            life2.color = new Vector4(255, 255, 255, 255);
            life3.color = new Vector4(0, 0, 0, 200);
        }
        if (livesLeft == 1)
        {
            Debug.Log("1 LIVES LEFT");
            life1.color = new Vector4(255, 255, 255, 255);
            life2.color = new Vector4(0, 0, 0, 200);
            life3.color = new Vector4(0, 0, 0, 200);
            
        }
        if (livesLeft == 0)
        {
            Debug.Log("0 LIVES LEFT");
            life1.color = new Vector4(0, 0, 0, 200);
            life2.color = new Vector4(0, 0, 0, 200);
            life3.color = new Vector4(0, 0, 0, 200);
        }
    }
    
}
