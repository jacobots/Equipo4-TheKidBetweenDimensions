using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour {

	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {

		this.spriteRenderer = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Usable") {

			this.spriteRenderer.enabled = true;
	

		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Usable") {

			this.spriteRenderer.enabled = false;


		}

	}

}
