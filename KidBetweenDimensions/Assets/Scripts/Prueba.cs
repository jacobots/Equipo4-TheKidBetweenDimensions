using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {

	public bool speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}
		
	}
}
