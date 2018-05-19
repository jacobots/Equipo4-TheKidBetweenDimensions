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
		targetVelocity = move * maxSpeed;

		if (Input.GetButtonDown ("Fire1"))
			inColliders.ForEach (n => n.SendMessage ("Use", SendMessageOptions.DontRequireReceiver));


	}

	void OnTriggerEnter2D(Collider2D col)
	{
		inColliders.Add (col);
	}

	void OnTriggerExit2D(Collider2D col)
	{
		inColliders.Remove (col);
	}



}
