using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_start_point : MonoBehaviour {
	public player_story_controller theplayer;
	public camera_storymode thecamera;

	// Use this for initialization
	void Start () {
		theplayer = FindObjectOfType<player_story_controller> ();
		theplayer.transform.position = transform.position;

		thecamera= FindObjectOfType<camera_storymode> ();
		thecamera.transform.position = new Vector3 (transform.position.x, transform.position.y, thecamera.transform.position.z);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
