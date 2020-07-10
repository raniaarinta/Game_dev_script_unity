using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame5_setatom : MonoBehaviour {
	public Sprite[] Sprite;
	public string element;
	int length=24;

	// Use this for initialization
	void Start () {
		setrandomgol ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setrandomgol ()
	{
		int index = Random.Range (0,length);

		switch (index) 
		{

		case 0:
			element = "Alkalimetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[0];
			break;
		case 1: 
			element = "alkaliearth";
			this.gameObject.GetComponent<Image>().sprite = Sprite[1];
			break;
		case 2:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[2];
			break;
		case 3:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[3];
			break;
		case 4:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[4];
			break;
		case 5: 
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[5];
			break;
		case 6:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[6];
			break;
		case 7:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite= Sprite[7];
			break;
		case 8:
			element = "metaltransision";
			this.gameObject.GetComponent<Image>().sprite = Sprite[8];
			break;
		case 9:
			element = "basicmetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[9];
			break;
		case 10:
			element = "basicmetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[10];
			break;
		case 11: 
			element = "semimetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[11];
			break;
		case 12:
			element = "semimetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[12];
			break;
		case 13:
			element = "nonmetal";
			this.gameObject.GetComponent<Image> ().sprite = Sprite[13];
			break;
		case 14:
			element = "nonmetal";
			this.gameObject.GetComponent<Image>().sprite = Sprite[14];
			break;
		case 15: 
			element = "halogen";
			this.gameObject.GetComponent<Image>().sprite = Sprite[15];
			break;
		case 16:
			element = "noblegas";
			this.gameObject.GetComponent<Image>().sprite = Sprite[16];
			break;
		case 17:
			element = "noblegas";
			this.gameObject.GetComponent<Image>().sprite= Sprite[17];
			break;
		case 18:
			element = "lanthanide";
			this.gameObject.GetComponent<Image>().sprite= Sprite[18];
			break;
		case 19:
			element = "lanthanide";
			this.gameObject.GetComponent<Image>().sprite = Sprite[19];
			break;
		case 20: 
			element = "lanthanide";
			this.gameObject.GetComponent<Image>().sprite = Sprite[20];
			break;
		case 21:
			element = "actinide";
			this.gameObject.GetComponent<Image>().sprite = Sprite[21];
			break;
		case 22:
			element = "actinide";
			this.gameObject.GetComponent<Image>().sprite = Sprite[22];
			break;
		case 23:
			element = "actinide";
			this.gameObject.GetComponent<Image>().sprite = Sprite[23];
			break;
		
		}
	}
}
