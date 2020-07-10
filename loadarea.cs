using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadarea : MonoBehaviour {
	public string leveltoload;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			if (leveltoload == "map_sm")
			{
				PlayerPrefs.SetString ("stage", "change_map");
				Application.LoadLevel(leveltoload);
			}
			Application.LoadLevel(leveltoload);

		}


	}
}
