using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	private player play;
	private GameObject gameOverUI;

	public void Start()
	{
		gameOverUI.SetActive(false);
	}
	public void MainMenu()
	{		
		Application.LoadLevel(0);
	}

	public void Retry()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

}
