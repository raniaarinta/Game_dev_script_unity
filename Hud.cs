using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

	public Sprite[] Heartsprites;
	public Image heartui;
	private player player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<player> ();
	}
	void Update()
	{
		if (player.currenthealth > 5) {
			heartui.sprite = Heartsprites [5];
		}
		else if(player.currenthealth<=0)
		{
				heartui.sprite = Heartsprites [0];
		}

		else
		heartui.sprite = Heartsprites[player.currenthealth];
	}

}
