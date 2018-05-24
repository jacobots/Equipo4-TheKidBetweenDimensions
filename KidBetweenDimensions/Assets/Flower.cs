using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {
	Animator anim;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "power") {
			anim.SetTrigger ("Fly");

			
		}



	}

	void OnTriggerStay2D (Collider2D other)
	{
		if(other.tag=="player"){
			transform.SetParent (transform);


	}

}

}
