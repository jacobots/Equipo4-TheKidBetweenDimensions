using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour {

	private Rigidbody2D rb;
	public float dashSpeed;
	private float dashTime;
	public float startDashTime;
	private int direction;
	public GameObject dashEffect;
	Animator anim;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		dashTime = startDashTime;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 0) {
			if (Input.GetAxisRaw ("Horizontal") < 0 && (Input.GetButtonDown("Fire3"))) {
				direction = 1;
				Instantiate (dashEffect, transform.position, Quaternion.identity);
				GetComponent<AudioSource> ().Play();


			} else if (Input.GetAxisRaw ("Horizontal") > 0 && (Input.GetButtonDown("Fire3"))) {
				direction = 2;

				Instantiate (dashEffect, transform.position, Quaternion.identity);



			} 

		} else {
			if (dashTime <= 0) {
				direction = 0;
				dashTime = startDashTime;
				rb.velocity = Vector2.zero;

			} else {
				dashTime -= Time.deltaTime;

				if (direction == 1) {
					rb.velocity = Vector2.left * dashSpeed;
					anim.SetTrigger ("Dash");

				} else if (direction == 2) {
					rb.velocity = Vector2.right * dashSpeed;
					anim.SetTrigger ("Dash");
		
				} 
			}


		
		}

	}

}

