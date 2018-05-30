using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleferico : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.SetTrigger ("moving");

	}

		if (other.gameObject.tag == "Player") {
			other.transform.parent = transform;

		}
}


}
