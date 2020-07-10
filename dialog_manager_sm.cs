using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog_manager_sm : MonoBehaviour {
	
	public GameObject dbox;
	public Text dtext;
	public bool dialogActive;
	public string[] dialogLines;
	public int currentline;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogActive && Input.GetKeyDown (KeyCode.Space)) 
		{
			//dbox.SetActive (false);
			//dialogActive = false;
			currentline++;
			if(currentline >= dialogLines.Length)
			{
				dbox.SetActive (false);
				dialogActive = false;
				currentline = 0;
			}
			dtext.text = dialogLines [currentline];

		}
		
	}
	public void showbox(string dialog)
	{
		dialogActive = true;
		dbox.SetActive (true);
		dtext.text = dialog;
		
	}
	public void showdialog()
	{
		dialogActive = true;
		dbox.SetActive (true);
		
	}
}
