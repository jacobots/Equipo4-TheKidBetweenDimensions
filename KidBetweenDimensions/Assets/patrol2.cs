using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol2 : MonoBehaviour {
	public float speed;
	private float waitTime;
	public float startWaitTime;
	public Transform[] moveSpots;
	private int randomSpot;
	public Transform enemy;
	float vx;
	private bool movingRight= true;
	Rigidbody2D rb;
	Animator anim;
	public float health = 30;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		waitTime = startWaitTime;

		randomSpot = Random.Range (0, moveSpots.Length);
		vx = rb.velocity.x;

	}
	
	// Update is called once per frame
	void Update () {
		Vector2 move = Vector2.zero;

		transform.position = Vector2.MoveTowards (transform.position, moveSpots [randomSpot].position, speed * Time.deltaTime);

		if (Vector2.Distance (transform.position, moveSpots[randomSpot].position) < 0.2f) {
			if (waitTime <= 0) {
				randomSpot = Random.Range (0, moveSpots.Length);
				waitTime = startWaitTime;
				

			} else {

				waitTime -= Time.deltaTime;

		}




		

				

		

	}

		if (health <= 0) {

			anim.SetTrigger ("Dead");
		}



	
}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.SetTrigger ("Attack");
			

		}

		if (other.tag == "power") {
			health = health - 10;
			anim.SetTrigger ("Attacked");

	}
	}




}




