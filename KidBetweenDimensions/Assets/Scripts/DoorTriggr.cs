using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggr : MonoBehaviour {
	public DoorScripts door;

	public bool ignoreTrigger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (ignoreTrigger)
			return;
		if (other.tag == "Player")
			door.DoorOpens ();
		
	}

	void OnTriggerExit2D(Collider2D other){

		if (ignoreTrigger)
			return;
		if (other.tag == "Player")
			door.DoorCloses ();

	}

	public void Toggle (bool state)
	{
		if (state)
			door.DoorOpens ();
		else
			door.DoorCloses ();

	}




}
