using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engranaje : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Rotate (0, 0, speed);
		
	}
}
