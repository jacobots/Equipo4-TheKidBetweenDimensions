using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
	public float destroyTime = 2;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {

		this.gameObject.transform.Rotate (0, 0, 3);
		
	}
}
