using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class datacontroller : MonoBehaviour {
	private playerprogres playerprogres;

	public rounddata[] allrounddata;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		LoadPlayerProgress ();
		SceneManager.LoadScene ("quiz_menu");
	}

	public rounddata getcurrentrounddata()
	{
		return allrounddata [0];
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void submitnewplayerscore(int newscore)
	{
		if (newscore > playerprogres.highestscore) {
			playerprogres.highestscore = newscore;
			saveplayerprogress ();
		}
		else 
		{
			saveplayerprogress ();
		}
	}
	private void LoadPlayerProgress()
	{
		playerprogres = new playerprogres ();
		if(PlayerPrefs.HasKey("highestscore"))
		{
			playerprogres.highestscore= PlayerPrefs.GetInt("highestscore");
		}
	}
	private void saveplayerprogress()
	{
		PlayerPrefs.SetInt ("highestscore", playerprogres.highestscore);
	}
	public int gethighsetplayerscore()
	{
		return playerprogres.highestscore;
	}
}
