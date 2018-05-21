using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour {
	Animator anim;
	public float health = 100f;
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

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "power") {
			health = (health - 35f);
			Instantiate (particleEffect, transform.position, Quaternion.identity);

		}

		if (health < 0f){
			camShake.Shake(camShakeAmt, 0.2f);
		}



			

			}

}
