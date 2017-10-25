using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	private int pinCount = 0;
    private static GameManager instance;

    //public property
    public int PinCount 
	{ 
			get { return pinCount; } 
			set{ pinCount = value; }
	}

    //public GameManager property
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject gameManager = new GameObject("GAME_MANAGER");
                DontDestroyOnLoad(gameManager);
                instance = gameManager.AddComponent<GameManager>();
            }

            return instance;
        }
    }
    private void OnEnable()
    {
        Pin.OnPinHitRotator += IncrementPinCount;
        Pin.OnPintHitPin += EndGame;
    }

    private void OnDisable()
    {
        Pin.OnPinHitRotator -= IncrementPinCount;
        Pin.OnPintHitPin -= EndGame;
    }

    private void EndGame()
    {
        SceneManager.LoadScene("gameOver", LoadSceneMode.Single);
    }

    private void IncrementPinCount()
    {
        PinCount++;
    }
}
