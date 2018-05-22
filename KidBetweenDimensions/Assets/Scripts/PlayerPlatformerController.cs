using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {
	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	private SpriteRenderer spriteRenderer;
	private bool attack;
	private Animator animator;
	List<Collider2D> inColliders=new List<Collider2D>();

	public bool dashIsActive = false;
	public float dashDistance = 10;
	public float dashSpeed = 0.2f;
	public float dashInitPosition = 0;
	public float dashEndPosition = 0;


	// Use this for initialization
	void Awake () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();
		
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



		// Dash
		  /*if(Input.GetKeyDown(KeyCode.C)) {

			// Activamos el movimiento automaticoa
			dashIsActive = true;

			// Guardamos la posicion inicial del dash
			dashInitPosition = this.gameObject.transform.position.x;

			if (faceDirection == true) {

				// Calculamos la distancia a recorrer automaticamente
				dashEndPosition = dashInitPosition + dashDistance;
			} else {
				dashEndPosition = dashInitPosition - dashDistance;
			}
		}

		if(dashIsActive == true) {

			// Hacemos el movimiento continuo del dash mientras no hayamos llegado al final
			if (this.gameObject.transform.position.x < dashEndPosition) {

				if (faceDirection == true) {
					this.gameObject.transform.Translate (dashSpeed, 0.0f, 0.0f);
				} else {
					this.gameObject.transform.Translate (-dashSpeed, 0.0f, 0.0f);
				}

			
			} else {

				// desactivamos el movimiento automaticoa
				dashIsActive = false;

			}
		}

	}


	void OnCollisonEnter2D() {
		if(dashIsActive == true) {
			// desactivamos el movimiento automaticoa
			dashIsActive = false;


		}
	}
	*/







}

}


