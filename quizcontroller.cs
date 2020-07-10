using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class quizcontroller : MonoBehaviour {
	public simpleobjectpool answerbuttonobjectpool;
	public Transform answerbuttonparent;
	public Text questiontext;
	private datacontroller datacontroller;
	private rounddata currentraounddata;
	private quetiondata[] questionpool;
	public Text timeremainingtext;

	public Text highscoredisplay;

	public GameObject questionpanel, roundoverpanel;
	public Text scoredisplaytext;
	private bool isarroundactive;
	private float timeremaining;
	private int questionindex;
	private int playerscore;
	private List<GameObject> answerButtonGameObject = new List<GameObject>();
	// Use this for initialization
	void Start () {
		datacontroller = FindObjectOfType<datacontroller> ();
		 currentraounddata = datacontroller.getcurrentrounddata ();
		questionpool = currentraounddata.questiondata;
		timeremaining =currentraounddata.timelimit;
		updatetimeremain ();
		//int index = Random.Range (0,3);
		playerscore =0;
		questionindex = 0;
		showquestion ();
		isarroundactive=true;
	}

	private void showquestion()
	{
		removeanswerbutton ();
		quetiondata questiondata = questionpool [questionindex];
		questiontext.text = questiondata.questiontext;
		for (int i = 0; i < questiondata.answers.Length; i++) 
		{
			GameObject answerbuttonobject = answerbuttonobjectpool.GetObject ();
			answerButtonGameObject.Add (answerbuttonobject);
			answerbuttonobject.transform.SetParent (answerbuttonparent);


			answerbutton answerbutton = answerbuttonobject.GetComponent<answerbutton> ();
			answerbutton.setup (questiondata.answers [i]);
		}
	}
	private void removeanswerbutton()
	{
		while(answerButtonGameObject.Count > 0 )
		{
			answerbuttonobjectpool.ReturnObject (answerButtonGameObject [0]);
			answerButtonGameObject.RemoveAt (0);

			
		}
	}
	public void answerbuttonclicked(bool iscorrect)
	{
		if (iscorrect) 
		{
			playerscore += currentraounddata.pointAddedCorrectAns;
			scoredisplaytext.text = "Score: "+playerscore.ToString ();

		}
		if (questionpool.Length > questionindex + 1) {
			questionindex++;
			showquestion ();
		} 
		else 
		{
			endround ();
		}
	}

	public void endround()
	{
		isarroundactive = false;

		questionpanel.SetActive (false);
		roundoverpanel.SetActive (true);
		datacontroller.submitnewplayerscore (playerscore);
		highscoredisplay.text = "highscore"+datacontroller.gethighsetplayerscore ().ToString ();
	}
	private void updatetimeremain()
	{
		timeremainingtext.text = "time" + Mathf.Round(timeremaining).ToString ();
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (isarroundactive) 
		{
			timeremaining -= Time.deltaTime;
			updatetimeremain ();
			if (timeremaining <= 0) 
			{
				endround ();
			}
		}

		
	}
}
