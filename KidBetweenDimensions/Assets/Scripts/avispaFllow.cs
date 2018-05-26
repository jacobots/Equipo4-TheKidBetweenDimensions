using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avispaFllow : MonoBehaviour {

	public float speed;

	private Transform target;
	public GameObject player;

	// Use this for initialization
	void Start () {

		target = player.GetComponent<Transform> (); 

		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector2.MoveTowards (transform.position, target.position, speed );
		
	}
}
