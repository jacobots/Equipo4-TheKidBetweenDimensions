using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avispa : MonoBehaviour {
	Animator anim;
	public float health = 50;
	float delay = 0.3f;
	CameraShake camShake;
	public float camShakeAmt = 0.1f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {

			anim.SetTrigger ("Dead");

			Destroy (gameObject, delay);


		}
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "power") {
			print ("ColisiónConPower");
			anim.SetTrigger ("Attacked");
			health = (health - 5f);
		








		}

		if (other.tag == "Player") {


		}



		if (health <= 0f) {
			anim.SetTrigger ("Dead");

			Destroy (gameObject, delay);
		}





	}


}
