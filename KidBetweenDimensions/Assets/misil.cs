using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misil : MonoBehaviour {
	public GameObject particleEffect;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector2.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Deadly") {
			
			Instantiate (particleEffect, transform.position, Quaternion.identity);


		}
}

}
