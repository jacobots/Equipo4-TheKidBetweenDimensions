using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadillo : MonoBehaviour {
	Animator anim;
	public float health;
	float delay = 0.6f;
	public float camShakeAmt = 0.1f;
	CameraShake camShake;
	public GameObject particleEffect;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();


		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "power") {
			health = (health - 10f);
			Instantiate (particleEffect, transform.position, Quaternion.identity);

			print ("ColisiónConPower");
		}

		if (health <= 0f) {
			anim.SetTrigger ("Dead");
			camShake.Shake (camShakeAmt, 0.1f);
			Destroy (gameObject, delay);
		}

	}




}
