using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setheart_minigame : MonoBehaviour {
	public Sprite Sprite2,Sprite1,Sprite0,sprite3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setsprite(int heart)
	{
		if (heart > 3) 
		{
			heart = 3;
		}
		if (heart == 3) 
		{
			this.gameObject.GetComponent<Image>().sprite = sprite3;
		}
		if (heart == 2) 
		{
			this.gameObject.GetComponent<Image>().sprite = Sprite2;
		}
		if (heart == 1) 
		{
			this.gameObject.GetComponent<Image>().sprite = Sprite1;
		}
		if (heart == 0) 
		{
			this.gameObject.GetComponent<Image>().sprite = Sprite0;
		}
	}
}
