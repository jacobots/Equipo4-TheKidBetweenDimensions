using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

	public DoorTriggr[] doorTrig;

	Animator anim;
	public bool sticks;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {


		
		
	}

	void OnTriggerStay2D()
	{
		anim.SetBool ("goDown", true);

		foreach (DoorTriggr trigger in doorTrig) {
			trigger.Toggle (true);


		}
	}

	void OnTriggerExit2D()
	{
		if (sticks)
			return;
		anim.SetBool ("goDown", false);
		foreach (DoorTriggr trigger in doorTrig) {
			trigger.Toggle (false);
		}

	}



}
