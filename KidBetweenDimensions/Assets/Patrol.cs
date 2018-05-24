using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public float health;
	public float speed;
	private bool movingRight= true;
	public Transform groundDetection;
	public GameObject particleEffect;
	public float camShakeAmt = 0.1f;
	CameraShake camShake;
	Animator anim;
	float delay = 0.6f;
	// Use this for initialization

	void Start (){
		anim = GetComponent<Animator> ();

	}

	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right * speed * Time.deltaTime);
		RaycastHit2D groundInfo = Physics2D.Raycast (groundDetection.position, Vector2.down, 2f);

		if (groundInfo.collider == false){
			if (movingRight == true) {
				transform.eulerAngles = new Vector3 (0, -180, 0);
				movingRight = false;

			} else {
				transform.eulerAngles = new Vector3(0,0,0);
				movingRight = true;


	}
	}







			
}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "power") {
			health = (health - 10f);

	}

		if (health <= 0f) {
			anim.SetTrigger ("Dead");

			Destroy (gameObject, delay);
		}





}
}

