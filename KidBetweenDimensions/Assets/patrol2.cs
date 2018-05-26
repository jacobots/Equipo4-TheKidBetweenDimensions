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
	bool dead = false;
	public float camShakeAmt = 0.1f;
	float delay = 2f;
	CameraShake camShake;
	public GameObject particleEffect;



	Animator anim;
	public float health ;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		waitTime = startWaitTime;

		randomSpot = Random.Range (0, moveSpots.Length);
		// camShake = GameObject.Find("_GM").GetComponent<CameraShake> ();


	}
	
	// Update is called once per frame
	void Update () {
		

			transform.position = Vector2.MoveTowards (transform.position, moveSpots [randomSpot].position, speed * Time.deltaTime);

			if (Vector2.Distance (transform.position, moveSpots [randomSpot].position) < 0.2f) {
				if (waitTime <= 0) {
					randomSpot = Random.Range (0, moveSpots.Length);
					waitTime = startWaitTime;
				

				} else {

					waitTime -= Time.deltaTime;

				}





		



		

				

		

			}



		if (health <= 0) {

			anim.SetTrigger ("Dead");
			dead = true;
			Destroy (gameObject, delay);
			waitTime -= Time.deltaTime;



		}



	
}

	void OnTriggerEnter2D(Collider2D other){
		


			if (other.tag == "power") {
			Instantiate (particleEffect, transform.position, Quaternion.identity);

				health = health - 5;
				anim.SetTrigger ("Attacked");
			anim.ResetTrigger ("Attacked");
			}




	}








}






