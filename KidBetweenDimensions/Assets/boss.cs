using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {
	public float speed;
	public Transform[] holes;
	public GameObject projectile;
	public Transform[] spots;

	Vector3 playerPos;
	public bool vulnerable;
	public float health = 500;
	public GameObject particleEffect;
	public GameObject player;
	Animator anim;
	// Use this for initialization
	void Start () {
		
		StartCoroutine ("bossie");
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			GetComponent<SpriteRenderer> ().color = Color.gray;
			StopCoroutine ("bossie");
			Instantiate (particleEffect, transform.position, Quaternion.identity);
		}
	}


	IEnumerator bossie()
	{ 
		
		while (true) {
			
			//First Attack
			while (transform.position.x != spots [0].position.x) {

				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (spots [0].position.x, transform.position.y), speed);
				yield return null;
			}
			transform.localScale = new Vector2 (-1, 1);
			yield return new WaitForSeconds (1f);

			int i = 0;
			while (i < 6) {

				GameObject bullet = (GameObject)Instantiate (projectile, holes [Random.Range (0, 0)].position, Quaternion.identity);
				bullet.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 20;

				i++;
				yield return new WaitForSeconds (.7f);

			}

			//Second Attack

			GetComponent<Rigidbody2D> ().isKinematic = true;
			while (transform.position != spots [2].position) {

				transform.position = Vector2.MoveTowards (transform.position, spots [2].position, speed);

				yield return null;
			}

			playerPos = player.transform.position;

			yield return new WaitForSeconds (1.3f);
			GetComponent<Rigidbody2D> ().isKinematic = false;

			while (transform.position.x != playerPos.x) {

				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (playerPos.x, transform.position.y), speed);
				yield return null;
			}
			this.tag = "Untagged";
			vulnerable = true;
			yield return new WaitForSeconds (4);

			vulnerable = false;




			// Third Attack
			Transform temp;
			if (transform.position.x > player.transform.position.x)
				temp = spots [1];
			else
				temp = spots [0];

			while (transform.position.x != temp.position.x) {

				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (temp.position.x, transform.position.y), speed);
				yield return null;
			}


		
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "power") {
			health = health - 10f;

		}



}



}



