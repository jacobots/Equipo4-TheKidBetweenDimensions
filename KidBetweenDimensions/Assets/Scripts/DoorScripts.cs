using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScripts : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoorOpens()
	{
		anim.SetBool ("Opens", true);
	}

	public void DoorCloses()
	{
		anim.SetBool ("Opens", false);
	}




}
