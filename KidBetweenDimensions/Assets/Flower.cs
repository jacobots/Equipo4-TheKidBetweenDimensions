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

		if (other.gameObject.tag == "Player") {
			other.transform.parent = transform;

		}



	}
		




	void OnTriggerExit2D (Collider2D other) {
			if(other.gameObject.tag == "Player") {
				other.transform.parent = null;
			}
		}

}


