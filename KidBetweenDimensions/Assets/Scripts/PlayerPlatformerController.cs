using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {
	private float kbTime;
	public float kbSpeed;
	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	private SpriteRenderer spriteRenderer;
	private bool attack;
	private Animator animator;
	public GameObject Torreta;
	Rigidbody2D myrigidbody2D;
	public Vector3 respawnPoint;

	public GameObject particleEffect;



	public float currentHealth;
	public float MaxHealth; 
	public float camShakeAmt = 0.1f;
	CameraShake camShake;


	public bool dashIsActive = false;
	public float dashDistance = 10;
	public float dashSpeed = 0.2f;
	public float dashInitPosition = 0;
	public float dashEndPosition = 0;
	Rigidbody2D rb;
	public float jumpBack=0.1f;



	// Use this for initialization
	void Awake () {
		
		rb = GetComponent<Rigidbody2D> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();
		MaxHealth = 100f;
		currentHealth = MaxHealth;
		camShake = GameObject.Find("_GM").GetComponent<CameraShake> ();
	
		
	}


	bool faceDirection = true; // true:right / false:left

	// Update is called once per frame

	protected override void ComputeVelocity()
	{
		
			
			Vector2 move = Vector2.zero;

			move.x = Input.GetAxis ("Horizontal");

			if (Input.GetButtonDown ("Jump") && grounded) {
				velocity.y = jumpTakeOffSpeed;

			} else if (Input.GetButtonUp ("Jump")) {
				if (velocity.y > 0)
					velocity.y = velocity.y * .5f;
			}




			if (move.x != 0) {
			
				if (move.x > 0) {
					faceDirection = true;
				} else {
					faceDirection = false;
				}
			}



			//bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));

			if (faceDirection == true) {
				spriteRenderer.flipX = false; // !spriteRenderer.flipX;
			} else {
				spriteRenderer.flipX = true;
			}

			animator.SetBool ("grounded", grounded);
			animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);
			animator.SetFloat ("velocityY", Mathf.Abs (velocity.y) / maxSpeed);
			targetVelocity = move * maxSpeed;








}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Deadly") {
			
			DealDamage (10);
			animator.SetTrigger ("damage");
			camShake.Shake (camShakeAmt, 0.1f);

		}

		if (other.tag == "Deadly2") {

			DealDamage (15);
			animator.SetTrigger ("damage");
			camShake.Shake (camShakeAmt, 0.1f);

		}

		if (other.tag == "fallDetector") {
			transform.position = respawnPoint;


		}

		if (other.tag == "checkpoint") {
			respawnPoint = other.transform.position;


		}



	
			

	

	}

	void OnTriggerStay2D(Collider2D other){

		if(other.tag == "turret"){

			if(Input.GetButton("Fire2")) {
				Torreta.SetActive (true);
				this.gameObject.SetActive (false);

			}

		}
	}

	void DealDamage(float damageValue)
	{

		currentHealth -= damageValue;








		if (currentHealth <= 0)

			Die ();

	}

	void Die () {
		animator.SetTrigger ("die");
		Instantiate (particleEffect, transform.position, Quaternion.identity);
		transform.position = respawnPoint;
		currentHealth = 100;

	}










		


}


