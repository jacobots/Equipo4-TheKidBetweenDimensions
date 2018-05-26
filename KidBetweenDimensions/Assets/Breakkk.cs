using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakkk : MonoBehaviour {

	Animator anim;
	public float health;
	public GameObject particleEffect;
	public float camShakeAmt = 0.1f;
	CameraShake camShake;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();
		camShake = GameObject.Find("_GM").GetComponent<CameraShake> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		anim.SetFloat ("Health" , health);


		
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.tag == "power") {
			health = (health - 35f);
			Instantiate (particleEffect, transform.position, Quaternion.identity);
			camShake.Shake(camShakeAmt, 0.1f);

		} 

		if (health < 0f){
			camShake.Shake(camShakeAmt, 0.3f);
		}
			



	}
}
