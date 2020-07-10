using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_storymode : MonoBehaviour {

	public GameObject followtarget;
	private Vector3 targetpos;
	public float movespeed;
	private static bool camExists;

	// Use this for initialization
	void Start () {
		
		if (!camExists) 
		{
			camExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		targetpos = new Vector3 (followtarget.transform.position.x, followtarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, targetpos, movespeed * Time.deltaTime);
	}
}
