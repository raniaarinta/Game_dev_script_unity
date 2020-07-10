using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialoge_manager : MonoBehaviour {
	public Text Dialogtext;
	public Button start_button;
	public bool Isaskbox;
	public Animator animator;
	public GameObject button_dialog_object, dialog_object;
	public bool iscloseddialogbox,isopendialogbox,isstorymode;
	public GameObject buttoncontrol;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();


	}
	
	// Update is called once per frame
	public void startdialog (Dialogue dialog)
	{
		isopendialogbox = true;
		if (isopendialogbox && isstorymode) 
		{
			buttoncontrol.SetActive (false);
		}
		
		animator.SetBool ("isopen", true);
		button_dialog_object.SetActive (true);
		dialog_object.SetActive (true);
		Debug.Log("starting conversatiom");

		sentences.Clear ();
		foreach (string sentence in dialog.sentences)
		{
			sentences.Enqueue (sentence);
			
		}

		DisplayNextSentence ();

	}
	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			enddialog ();
			return;
		}
		string s = sentences.Dequeue (); 
		StopAllCoroutines ();
		StartCoroutine (TypeSentence(s));
		//Debug.Log (s);
		//Dialogtext.text = s;

	}

	IEnumerator TypeSentence(string sentence)
	{
		Dialogtext.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			Dialogtext.text += letter;
			yield return null;
		}

	}
	void enddialog()
	{
		Debug.Log ("end sentence");
		animator.SetBool ("isopen", false);
		button_dialog_object.SetActive (false);
		dialog_object.SetActive (false);
		iscloseddialogbox=true;
		if (iscloseddialogbox && isstorymode) 
		{
			buttoncontrol.SetActive (true);
		}

	}


}
