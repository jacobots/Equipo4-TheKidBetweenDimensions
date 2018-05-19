using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public bool IsOpen;
	Animator doorAnimator;
	Collider2D doorCollider;

	// Use this for initialization
	void Start () {

		doorAnimator = GetComponent<Animator> ();
		doorCollider = GetComponent<Collider2D> ();

	}

	public void Open()
	{
		if (!IsOpen)
			SetState (true);
	}

	public void Close()
	{
		if (IsOpen)
			SetState (false);
	}

	public void Toggle()
	{
		if (IsOpen)
			Close();
		else
			Open();
			
	}

	
	// Update is called once per frame
	void SetState (bool open) {
		IsOpen = open;
		doorAnimator.SetBool ("Open", open);
		doorCollider.isTrigger = open;
	}
}
