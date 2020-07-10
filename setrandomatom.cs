using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setrandomatom : MonoBehaviour {

	public Sprite [] Sprite;
	int length =10;
	public string element;

	// Use this for initialization
	void Start () {
		setrandomgol ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//element 1 atom =h,he
	//element 2 atom=li,be
	//element 3 atom= b,c,n,o,f,ne
	//element 4 atom=na,mg
	//elemen 5 atom=al,si,p,s,cl,ar
	//element 6 atom K,Ca
	public void setrandomgol ()
	{
		int index = Random.Range (0,length);

		switch (index) 
		{

		case 0:
			element = "element1";
			this.gameObject.GetComponent<Image>().sprite = Sprite[0];
			break;
		case 1: 
			element = "element2";
			this.gameObject.GetComponent<Image>().sprite= Sprite[1];
			break;
		case 2:
			element = "element3";
			this.gameObject.GetComponent<Image>().sprite = Sprite[2];
			break;
		case 3:
			element = "element3";
			this.gameObject.GetComponent<Image>().sprite = Sprite[3];
			break;
		case 4:
			element = "element3";
			this.gameObject.GetComponent<Image>().sprite= Sprite[4];
			break;
		case 5: 
			element = "element4";
			this.gameObject.GetComponent<Image>().sprite = Sprite[5];
			break;
		case 6:
			element = "element5";
			this.gameObject.GetComponent<Image>().sprite = Sprite[6];
			break;
		case 7:
			element = "element5";
			this.gameObject.GetComponent<Image>().sprite = Sprite[7];
			break;
		case 8:
			element = "element5";
			this.gameObject.GetComponent<Image>().sprite = Sprite[8];
			break;
		case 9:
			element = "element6";
			this.gameObject.GetComponent<Image>().sprite = Sprite[9];
			break;
		}
	}
}
