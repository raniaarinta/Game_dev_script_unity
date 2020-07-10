using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questtrigger : MonoBehaviour {

	private questmanager QM;
	public int questnumber;
	public bool startquest;
	public bool endquest;


	// Use this for initialization
	void Start () {
		QM = FindObjectOfType<questmanager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "player") 
		{
			if (!QM.questcompleted[questnumber]) 
			{
				if (startquest && !QM.quest[questnumber].gameObject.activeSelf) 
				{
					QM.quest [questnumber].gameObject.SetActive (true);
					QM.quest [questnumber].startquest ();
				}
				if (endquest && QM.quest [questnumber].gameObject.activeSelf) 
				{
					QM.quest [questnumber].endquest();
				}
			}
		}
	}
}
