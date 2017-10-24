using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	private int pinCount;

	public int PinCount 
	{ 
			get { return pinCount; } 
			set{ (value > 0) ? pinCount = value : Debug.LogAssertion ("Invalid pinCount" + value + ""); }
	}
		
    private static GameManager instance;
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
}
