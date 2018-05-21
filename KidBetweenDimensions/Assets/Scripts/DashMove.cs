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


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		dashTime = startDashTime;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 0) {
			if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.C)) {
				direction = 1;
				Instantiate (dashEffect, transform.position, Quaternion.identity);



			} else if (Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.C)) {
				direction = 2;

				Instantiate (dashEffect, transform.position, Quaternion.identity);


			} else if (Input.GetKey (KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.C)) {
				direction = 3;
			} else if (Input.GetKey (KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.C)) {
				direction = 4;
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

				} else if (direction == 2) {
					rb.velocity = Vector2.right * dashSpeed;
		
				} else if (direction == 3) {
					rb.velocity = Vector2.up * dashSpeed;
				} else if (direction == 4) {
					rb.velocity = Vector2.down * dashSpeed;
				}
			}


		
		}

	}

}

