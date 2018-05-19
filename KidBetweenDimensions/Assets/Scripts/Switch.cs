using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	Animator doorAnimator;
	public GameObject Target;
	public string OnMessage;
	public string OffMessage;
	public bool IsOn;

	// Use this for initialization
	void Start () {
		doorAnimator = GetComponent<Animator> ();
		
	}

	public void TurnOn()
	{
		if (!IsOn)
			SetState (true);
	}

	public void TurnOff()
	{
		if (IsOn)
			SetState (false);
	}

	public void Toggle()
	{
		if (IsOn)
			TurnOff ();
		else
			TurnOn ();
	}

	// Update is called once per frame
	void SetState(bool on)
	{
		IsOn = on;
		doorAnimator.SetBool ("On", on);
		if (on) {
			if (Target != null && !string.IsNullOrEmpty (OnMessage))
				Target.SendMessage (OnMessage);
		} else {
			if (Target != null && !string.IsNullOrEmpty (OffMessage))
				Target.SendMessage (OffMessage);
		}
	}

}
