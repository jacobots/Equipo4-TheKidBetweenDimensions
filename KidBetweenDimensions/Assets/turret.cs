using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour {
	public float speed;
	public GunController theGun;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (0, 0, Input.GetAxis ("Horizontal") * speed * Time.deltaTime);
			


		if (Input.GetButtonDown ("Fire1")) {

			theGun.isFiring = true;

		}
		

		if (Input.GetButtonUp ("Fire1")) {
			theGun.isFiring = false;

		}

			
			
	}
}
