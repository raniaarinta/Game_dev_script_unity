using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class minigame3_controller : MonoBehaviour {
	public Text timertext;
	public float timer;
	public GameObject gamepanel, gameoverpanel,finishgamepanel;
	public setrandomatom randomatom;
	public int heart;
	public bool isstorymode;
	public player_story_controller player;
	public	Dialoge_manager dm;
	public int playerheart, playercoins;

	public setheart_minigame setheart_minigame;
	// Use this for initialization
	void Start () {
		updatetimeremain ();
		heart = 3;

	}
	
	// Update is called once per frame
	void Update () {
		if (dm.iscloseddialogbox) {
			timer -= Time.deltaTime;
			updatetimeremain ();
		}

		if (timer <= 0) 
		{
			gameover ();
		}

		if (heart <= 0) 
		{
			gameover ();
		}
	
	}
	private void updatetimeremain()
	{
		timertext.text = "time" + Mathf.Round(timer).ToString ();


	}

	public void gameover()
	{
		
		if (isstorymode) {
			playerheart= PlayerPrefs.GetInt ("heart") - 1;
			PlayerPrefs.SetInt ("heart", playerheart);
			SceneManager.LoadScene ("sm_class_3");
		} 
		else 
		{
			gameoverpanel.SetActive (true);
			gamepanel.SetActive (false);
		}
	}
	public void finishgame()
	{
		
		if (isstorymode) {
			playercoins=PlayerPrefs.GetInt ("coin")+100;
			PlayerPrefs.SetInt ("coin", playercoins);
			SceneManager.LoadScene ("sm_class_3");
		} 
		else 
		{
			
			finishgamepanel.SetActive (true);
			gamepanel.SetActive (false);
		}
	}
	public void buttonclick(Button button)
	{
		if (button.name.ToString() == randomatom.element) 
		{
			finishgame ();
		}
		if (button.name.ToString() != randomatom.element) 
		{
			setheartminus();
		}
	}
	public void setheartminus()
	{
		heart = heart - 1;
		setheart_minigame.setsprite (heart);

	}


}
