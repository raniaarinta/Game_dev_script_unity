using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerbutton : MonoBehaviour {

	public Text answertext;
	private answerdata answer_data;
	private quizcontroller quizcontroller;

	// Use this for initialization
	void Start () {
		quizcontroller = FindObjectOfType<quizcontroller> ();
	}
	public void setup(answerdata data)
	{
		answer_data = data;
		answertext.text = answer_data.answertext;
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void HandleClick()
	{
		quizcontroller.answerbuttonclicked (answer_data.iscorrect);
	}
}
