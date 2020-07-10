using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_trigger : MonoBehaviour {
	public Dialogue dialog;

	public void TriggerDialog()
	{
		FindObjectOfType<Dialoge_manager> ().startdialog(dialog);
	}

	// Use this for initialization

}
