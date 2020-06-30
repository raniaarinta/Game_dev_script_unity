using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	private bool attacking=false;
	private float attackTimer = 0;
	private float attackCd = 0.3f;

	public Collider2D attackTigger;

	private Animator anim;

	void Awake()
	{
		anim = gameObject.GetComponent<Animator> ();
		attackTigger.enabled = false;

	}
	void Update()
	{
		if (Input.GetKeyDown ("f") && !attacking) 
		{
			attacking = true;
			attackTimer = attackCd;
			attackTigger.enabled = true;
		}
		if (attacking) 
		{
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			}
			else 
			{
				attacking = false;
				attackTigger.enabled = false;
			}

		}

		anim.SetBool("Attacking",attacking);
	}
}
