using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planta : MonoBehaviour {
	Animator anim;
	public float health = 50;
	public GameObject particleEffect;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			anim.SetTrigger ("Dead");
		}
		
	}

	void OnTriggerEnter2D(Collider2D other){



		if (other.tag == "power") {
			Instantiate (particleEffect, transform.position, Quaternion.identity);

			health = health - 10;
			anim.SetTrigger ("Attacked");
		}



}

}
