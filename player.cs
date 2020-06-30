using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float maxSpeed = 3;
	public float speed=50f;
	public float jumpPower=150f;
	private bool paused = false;
	
	public bool grounded;
    public bool canDoubleJump;

	private Rigidbody2D rb2d;
    private Animator anim;
	public GameObject gameOverUI;

	//life
	public int currenthealth;
	public int maxhealth=5;
	
	void Start () {
		rb2d=gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
		currenthealth = maxhealth;
		gameOverUI.SetActive (false);
    }
	
	
	void Update () {
        anim.SetBool("Grounded",grounded);
        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        
        if(Input.GetAxis("Horizontal")< -0.1f)
        {
            transform.localScale = new Vector3(-2, 2, 1);
        }

        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(2, 2, 1);
        }

        if(Input.GetButtonDown("Jump"))
        {
            if(grounded)
            {
                rb2d.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
            }
            else
            {
                if(canDoubleJump)
                {
                    canDoubleJump = false;
                    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                    rb2d.AddForce(Vector2.up * jumpPower);
                }
            }
        }
		if (currenthealth > maxhealth) {
			currenthealth = maxhealth;
		}
		if (currenthealth <= 0) {			
			Time.timeScale = 0;
			die ();
		}
    }


	void FixedUpdate()
	{
        Vector3 easeVelocity = rb2d.velocity;
        easeVelocity.y = rb2d.velocity.y;
        easeVelocity.z = 0.0f;
        easeVelocity.x *= 0.75f;

        float h = Input.GetAxis("Horizontal");

        if(grounded)
        {
            rb2d.velocity = easeVelocity;
        }

        rb2d.AddForce((Vector2.right * speed) * h);
        
        if(rb2d.velocity.x >maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }

        if (rb2d.velocity.x <-maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
	}

	public void die()
	{
		//restart
		gameOverUI.SetActive(true);
	}

	public void MainMenu()
	{		
		Application.LoadLevel(0);
	}

	public void Retry()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
	public void damage(int dmg){
		currenthealth -= dmg;
		gameObject.GetComponent<Animation>().Play("RedFlash_Player");
	}
	public void addlife()
	{
		currenthealth = currenthealth+1;
	}

	public IEnumerator Knockback(float knockDur, float knockBackPower, Vector3 knockbackDirection)
	{
		float timer = 0;
		while (knockDur > timer) {
			timer += Time.deltaTime;

			rb2d.AddForce (new Vector3 (knockbackDirection.x * -100, knockbackDirection.y * knockBackPower, transform.position.z));

		}
		yield return 0;
	}
		
}
