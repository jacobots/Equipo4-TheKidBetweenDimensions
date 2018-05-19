using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public float speed;
	private bool movingRight= true;
	public Transform groundDetection;
	// Use this for initialization

	
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
}

