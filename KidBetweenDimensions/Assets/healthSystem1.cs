using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem1 : MonoBehaviour {

	public float currentHealth;
	public float MaxHealth; 
	public float camShakeAmt = 0.1f;
	private bool isattacked;
	private Animator animator;
	CameraShake camShake;


	// Use this for initialization
	void Start () {
		MaxHealth = 100f;
		currentHealth = MaxHealth;
		isattacked = false;
		animator = this.gameObject.GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Deadly") {
			DealDamage (10);
			isattacked = true;

		}

		if (isattacked = true) {
			


		}
		
	}

	void DealDamage(float damageValue)
	{
		
		currentHealth -= damageValue;

		animator.SetTrigger ("damage");

		// camShake.Shake (camShakeAmt, 0.1f);



		if (currentHealth <= 0)
			
			Die ();

	}

	void Die () {
		animator.SetTrigger ("die");
		currentHealth = 0;

	}
}

