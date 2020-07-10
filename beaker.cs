using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class beaker : MonoBehaviour {
    Rigidbody2D rgb;
   public float speed;
    public Text score_text,timer_text;
    private int counter;
    private int counter_benar;
	public int total_benar;
    public Text win_text;
	public float timer;
	public GameObject panelover,panelwin,controller;
	public Dialoge_manager dm;
	public int playerheart, playercoins;
	public bool isstorymode;

     void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        counter = 0;
        counter_benar = 0;
        setscore();
        win_text.text = "";
    }
	void Update () {
		if (dm.iscloseddialogbox) 
		{
			controller.SetActive (true);
			timer -= Time.deltaTime;
			updatetimeremain ();
			if (timer <= 0) 
			{
				panelover.SetActive (true);
			}

		}

		//if (heart <= 0) 
		//{
		//	gameover ();
		//}

	}
    void FixedUpdate()
    {
		float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
		float moveVertical= CrossPlatformInputManager.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rgb.AddForce(movement * speed);

        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("atom"))
        {
            collision.gameObject.SetActive(false);
            counter = counter + 100;
            counter_benar = counter_benar + 1;
            setscore();
            check_gameover();
            check_win();
        }
       else  if (collision.gameObject.CompareTag("poison"))
        {
            collision.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       else if (collision.gameObject.CompareTag("atom_salah"))
        {
            collision.gameObject.SetActive(false);
            counter = counter - 100;
            check_gameover();
            setscore();

        }

    }

    void setscore()
    {
        score_text.text = "Score: "+counter.ToString();
    }

   void check_gameover()
    {

        if (counter <= 0)
        {
			if (isstorymode) {
				playerheart= PlayerPrefs.GetInt ("heart") - 1;
				PlayerPrefs.SetInt ("heart", playerheart);
				SceneManager.LoadScene ("sm_class_2");
			} 
			panelover.SetActive (true);
        }
      
    }

    void check_win()
	{ if (total_benar == counter_benar)
        {
			if (isstorymode) {
				playercoins=PlayerPrefs.GetInt ("coin")+100;
				PlayerPrefs.SetInt ("coin", playercoins);
				SceneManager.LoadScene ("sm_class_2");
			} 
			panelwin.SetActive (true);
			PlayerPrefs.SetInt ("coin", PlayerPrefs.GetInt ("coin") +100);
			win_text.text = "Score= "+counter.ToString();

        }
        
    }
	private void updatetimeremain()
	{
		timer_text.text = "time" + Mathf.Round(timer).ToString ();


	}
}
