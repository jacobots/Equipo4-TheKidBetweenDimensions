using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATTACK : MonoBehaviour {

	public Animator animatorPlayer;
	float m_CurrentSpeed;
	bool isAttacking;

	// Use this for initialization
	void Start () {
		//animatorPlayer = this.transform.Find ("Player").gameObject.GetComponent<Animator> ();

		/*
		if(animatorPlayer == null) {
			
			// codigo para cargar el player
			GameObject player = Instantiate( Resources.Load("/charactersPlayer") as GameObject);
			player.transform.position = Vector3.zero;

			// Obtienes una referencia al compoennet animator del playr
			animatorPlayer = this.transform.Find ("Player").gameObject.GetComponent<Animator> ();
		}
		*/
		m_CurrentSpeed = animatorPlayer.GetCurrentAnimatorStateInfo(0).speed;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {

			animatorPlayer.SetTrigger ("Attack");


		}

		if(animatorPlayer.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
			{
				isAttacking = true;
			}

			else {
				isAttacking = false;
		
			}

		if (isAttacking == true) {
			GameObject player = GameObject.Find ("Player");
			GameObject power = GameObject.Find ("Power");
			power.transform.position = player.transform.position;

			power.GetComponent<BoxCollider2D> ().enabled = true;
		} else {

			GameObject power = GameObject.Find ("Power");
			power.GetComponent<BoxCollider2D> ().enabled = false;
		}
		}


	
}
