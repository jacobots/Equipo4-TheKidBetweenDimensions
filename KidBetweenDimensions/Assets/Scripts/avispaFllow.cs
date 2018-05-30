using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avispaFllow : MonoBehaviour {

	public float speed;
	public GameObject particleEffect;
	public float camShakeAmt = 0.1f;
	CameraShake camShake;
	float delay = 2;

	private Transform target;
	public GameObject player;


	// Use this for initialization
	void Start () {

		target = player.GetComponent<Transform> (); 


		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player") {
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed );

		}



		}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "power") {
			
			Instantiate (particleEffect, transform.position, Quaternion.identity);
			Destroy (gameObject, delay);
		
		}
	}



		}



	


