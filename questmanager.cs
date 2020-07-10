using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questmanager : MonoBehaviour {
	public questobject[] quest;
	public bool[] questcompleted;

	public dialog_manager_sm Dm;

	// Use this for initialization
	void Start () {
		questcompleted = new bool[quest.Length];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showquesttext(string questtext)
	{
		Dm.dialogLines = new string[1];
		Dm.dialogLines [0] = questtext;
		Dm.currentline = 0;
		Dm.showdialog ();

	}
}
