using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

	public DoorTriggr[] doorTrig;

	Animator anim;
	public bool sticks;
	CameraShake camShake;
	public float camShakeAmt = 0.2f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		camShake = GameObject.Find("_GM").GetComponent<CameraShake> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D()
	{

		// Solo iniciamos la animacion del la palnaca si el personaje esta dentro del collider
		// Y si el player presiona la teclaE
		if(Input.GetKey(KeyCode.E)) {
			
			camShake.Shake(camShakeAmt, 0.2f);
			
			anim.SetBool ("goDown", true);

			foreach (DoorTriggr trigger in doorTrig) {
				trigger.Toggle (true);
			}			
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
