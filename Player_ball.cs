using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player_ball : MonoBehaviour {
    public float jumpforce = 10f;
    public Rigidbody2D rb;
	public Sprite satuA, duaA, tigaA, empatA; 
	public Sprite limiaA,enamA,tujuhA,delapanA;
	public Sprite satuB, duaB, tigaB, empatB; 
	public Sprite limiaB,enamB,tujuhB,delapanB;
	public GameObject gameoverobject,winningobject;
	public bool isgameover;
	public string level;
	public int score;
	public Text score_text;
	public Dialoge_manager dm;
	public int playerheart, playercoins;
	public bool isstorymode;
   
	public string currentgol;
    

	// Use this for initialization
	void Start () {
		if (level == "satu") 
		{
			setrandomgol ();
		}
		if (level == "dua") 
		{
			setrandomgol ();
		}
		if (level == "tiga") 
		{
			setrandomgol_jenis2a ();
		}
		if (level == "empat") 
		{
			setrandomgol_jenis1b ();
		}
		if (level == "lima") 
		{
			setrandomgol_jenis2b ();
		}
		if (level == "enam") 
		{
			setrandomgol_jenis2a ();
		}

		isgameover = false;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	//	if(dm.iscloseddialogbox)
			

		if (CrossPlatformInputManager.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpforce;

        }
	}
	void setrandomgol ()
	{
		int index = Random.Range (0,3);

		switch (index) 
		{
		case 0:
			currentgol = "satuA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = satuA;
			break;
		case 1: 
			currentgol = "duaA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = duaA;
			break;
		case 2:
			currentgol = "tigaA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = tigaA;
			break;
		case 3:
			currentgol = "empatA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = empatA;
			break;

		}
	}
	void setrandomgol_jenis2a()
	{
		int index = Random.Range (0,3);

		switch (index) 
		{
		case 0:
			currentgol = "limaA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = limiaA;
			break;
		case 1: 
			currentgol = "enamA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = enamA;
			break;
		case 2:
			currentgol = "tujuhA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = tujuhA;
			break;
		case 3:
			currentgol = "delapanA";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = delapanA;
			break;

		}
	}
	void setrandomgol_jenis1b()
	{
		int index = Random.Range (0,3);

		switch (index) 
		{
		case 0:
			currentgol = "satuB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = satuB;
			break;
		case 1: 
			currentgol = "duaB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = duaB;
			break;
		case 2:
			currentgol = "tigaB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = tigaB;
			break;
		case 3:
			currentgol = "empatB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = empatB;
			break;

		}
	}
	void setrandomgol_jenis2b()
	{
		int index = Random.Range (0,3);

		switch (index) 
		{
		case 0:
			currentgol = "limaB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = limiaB;
			break;
		case 1: 
			currentgol = "enamB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = enamB;
			break;
		case 2:
			currentgol = "tujuhB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = tujuhB;
			break;
		case 3:
			currentgol = "delapanB";
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = delapanB;
			break;

		}
	}


    void OnTriggerEnter2D(Collider2D col)
    {
		if (col.tag == "golchanger") 
		{
			setrandomgol ();
			Destroy (col.gameObject);
			return;
		}
		if (col.tag == "golchanger_jenis2a") 
		{
			setrandomgol_jenis2a ();
			Destroy (col.gameObject);
			return;
		}
		if (col.tag == "golchanger_jenis1b") 
		{
			setrandomgol_jenis2a ();
			Destroy (col.gameObject);
			return;
		}
		if (col.tag == "golchanger_jenis2b") 
		{
			setrandomgol_jenis2b ();
			Destroy (col.gameObject);
			return;
		}
		if (col.tag != currentgol) 
		{
			gameover ();
		}
		if (col.tag == currentgol) 
		{
			score=score+100;
			setscore ();
		}
		if (col.tag == "finish_minigame_satu") 
		{
			completelevel ();
			Destroy (col.gameObject);
			return;
		}

    }
	public void gameover()
	{
		isgameover = true;
		gameoverobject.SetActive (true);
		if (isstorymode) {
			playerheart= PlayerPrefs.GetInt ("heart") - 1;
			PlayerPrefs.SetInt ("heart", playerheart);
			SceneManager.LoadScene ("sm_class_1");
		} 
		
	}
	public void completelevel()
	{
		if (isstorymode) {
			playercoins=PlayerPrefs.GetInt ("coin")+100;
			PlayerPrefs.SetInt ("coin", playercoins);
			SceneManager.LoadScene ("sm_class_1");
		} 
		isgameover = true;
		PlayerPrefs.SetInt ("coin", PlayerPrefs.GetInt ("coin") +100);
		winningobject.SetActive (true);

	}
	public void buttonhome()
	{
		SceneManager.LoadScene ("");
	}
	void setscore()
	{
		score_text.text = "Score: "+score.ToString();
	}
}
