using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seems : MonoBehaviour {
	public SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
		this.spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "seems") {

			this.spriteRenderer.enabled = true;


		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "seems") {

			this.spriteRenderer.enabled = false;


		}

	}
}
