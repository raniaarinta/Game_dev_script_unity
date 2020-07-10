using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class dialogholder : MonoBehaviour {

	public string dialog;
	private dialog_manager_sm dMan;
	public string[] dialoglines;
	public GameObject button;
	bool ispressed;
	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<dialog_manager_sm> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buttonask()
	{
		 ispressed = true;
	}
	void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
//			button.SetActive (true);
			//if(ispressed)
			if (Input.GetKeyUp(KeyCode.Space))
			{
				//dMan.showbox (dialog);
				if (!dMan.dialogActive) 
				{
					dMan.dialogLines = dialoglines;
					dMan.currentline = 0;
					dMan.showdialog ();
				}
			}
		}
	

	}
}
