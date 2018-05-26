using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemReactor : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponentInParent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void OnTriggerEnter2D(Collider2D other){



		if (other.tag == "Player") {
			
			anim.SetTrigger ("Attack");
		
		}
}

}
