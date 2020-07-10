using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questobject : MonoBehaviour {

	public int questnumber;
	public questmanager qm;
	public string starttext;
	public string endtext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startquest()
	{
		qm.showquesttext (starttext);
	}
	public void endquest()
	{
		qm.showquesttext (endtext);
		qm.questcompleted [questnumber] = true;
		gameObject.SetActive (false);
	}
}
