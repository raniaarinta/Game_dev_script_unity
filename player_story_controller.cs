using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
public class player_story_controller : MonoBehaviour {
	public float movespeed;
	private Rigidbody2D myRigidBody;
	private static bool playerExists;
	private Animator anim;
	public int heart, coin;
	public Image heartimg;
	public setheart_minigame heart_sprite;
	public Text cointext,gameoverdes;
		GameObject panelresart,panelgameover,buttonyesno,buttonreturn;
	public string gameoveroption,restartcoin;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		myRigidBody = GetComponent<Rigidbody2D> ();
		//heart = 3;
		coin=PlayerPrefs.GetInt("coin");
		heart=PlayerPrefs.GetInt ("heart");
		//PlayerPrefs.SetInt ("heart", 3);
		//PlayerPrefs.SetInt ("coin", 300);
		if (!playerExists) 
		{
			playerExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}

		setcoinUI ();
		setheartUI ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (CrossPlatformInputManager.GetAxisRaw("Horizontal") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Horizontal") < -0.5f)
		{
			//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")* movespeed*Time.deltaTime,0f,0f));
			myRigidBody.velocity = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal") *movespeed ,myRigidBody.velocity.y);
		}

		if (CrossPlatformInputManager.GetAxisRaw("Vertical") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Vertical") < -0.5f)
		{
			//transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical")* movespeed*Time.deltaTime,0f));
			myRigidBody.velocity = new Vector2(myRigidBody.velocity.x,CrossPlatformInputManager.GetAxisRaw("Vertical")*movespeed);
		}

		if (CrossPlatformInputManager.GetAxisRaw ("Horizontal") < 0.5f && CrossPlatformInputManager.GetAxisRaw ("Horizontal") > -0.5f)
		{
			myRigidBody.velocity = new Vector2 (0f , myRigidBody.velocity.y);
		}
		if (CrossPlatformInputManager.GetAxisRaw ("Vertical") < 0.5f && CrossPlatformInputManager.GetAxisRaw ("Vertical") > -0.5f) 
		{
			myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x ,0f);
		}

		anim.SetFloat("MoveX", CrossPlatformInputManager.GetAxisRaw ("Horizontal"));
		anim.SetFloat("MoveY", CrossPlatformInputManager.GetAxisRaw ("Vertical"));





	}

	public void setcoinUI()
	{
		cointext.text = "coins: "+PlayerPrefs.GetInt("coin").ToString();
	}
	public void setheartUI()
	{
		heart_sprite.setsprite (PlayerPrefs.GetInt("heart"));
	}
	public void buttongameover(Button button,string options)
	{
		options = gameoveroption;
		
	}
	public void buttonpanelyes (Button button, string options)
	{
		options = restartcoin;
	}
	public void buttonover()
	{
		SceneManager.LoadScene ("map_sm");
	}
	public void gameover()
	{
		panelgameover.SetActive (false);
	//	buttonyesno.SetActive (true);
	//	buttonreturn.SetActive (false);
	//	panelresart.SetActive (true);

	//	if (gameoveroption == "yes") 
		//{
			
		//	if (coin < 100) 
		//	{
		//		gameoverdes.text = "maaf koin ada tidak cukup";
		//		buttonreturn.SetActive (true);
		//		buttonyesno.SetActive (false);
				//panelgameover.SetActive (true);

		//	} 
		//	else  if (coin >= 100) 
		//	{
				//gameoverdes.text = "";
				//paneloption.SetActive (true);

			//		PlayerPrefs.SetInt ("heart", PlayerPrefs.GetInt ("heart") +1);
			//		PlayerPrefs.SetInt ("coin", PlayerPrefs.GetInt ("coin") -100);
			///		setheartUI ();
			//		setcoinUI ();
					//SceneManager.LoadScene (SceneManager.GetActiveScene ().name);


			//}
			
			
		//}
		//if (gameoveroption == "no") 
		//{
		//	panelgameover.SetActive (true);
			
		//}
	}

	public void Button_yes_press()
	{
		gameoveroption = "yes";
	}
	public void Button_no_press()
	{
		gameoveroption= "no";
		panelresart.SetActive (false);
		panelgameover.SetActive (true);

	}
	public void button_return()
	{
		panelresart.SetActive (false);
		panelgameover.SetActive (true);
	}
		
}



