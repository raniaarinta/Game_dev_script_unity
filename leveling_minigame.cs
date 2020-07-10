using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leveling_minigame : MonoBehaviour {
	GameObject minigame1;
	GameObject minigame2;
	GameObject minigame3;
	GameObject des;
	Text des_text;
	// Use this for initialization
	void Start () {
		minigame1 = GameObject.Find ("minigame1");
		minigame2 = GameObject.Find ("minigame2");
		minigame3 = GameObject.Find ("minigame3");
		des = GameObject.Find ("desc");
		des_text = des.GetComponent<Text> ();
		des_text.text = "";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void button_hover(Button button)
	{
		if (button.name == "buttonM1") 
		{
			minigame1.transform.SetAsLastSibling ();
			des_text.text="minigame ini merupakan minigame untuk mengklasifikasikan atom berdasarkan golongan";
		}
		else if (button.name == "buttonM2") 
		{
			minigame2.transform.SetAsLastSibling ();
			des_text.text = "minigame ini merupakan minigame untuk mengklasifikasikan atom berdasarkan periode";
		}
		else if(button.name=="buttonM3")
		{
			minigame3.transform.SetAsLastSibling ();
			des_text.text = "minigame ini merupakan minigame untuk mengklasifikasikan atom berdasarkan sifat atom";
		}
	}

	public void loadminigaame1()
	{
		loadscene("level_selector_m1");
		
	}
	public void loadminigaame2()
	{
		loadscene("level_selector_m2");
	}
	public void loadscene(string level_name)
	{
		SceneManager.LoadScene (level_name);
	}
}
