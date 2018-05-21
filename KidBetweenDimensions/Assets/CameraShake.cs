using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public Camera mainCam;
	float shakeAmount = 0;

	void Awake(){

		if (mainCam == null)
			mainCam = Camera.main; 
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			Shake
			(0.2f, 0.1f);
		}
	}

	public void Shake(float amt, float lenght){

		shakeAmount = amt;
		InvokeRepeating ("BeginShake", 0, 0.01f);
		Invoke ("StopShake", lenght);


	}

	void BeginShake(){
		if (shakeAmount > 0) {
			Vector3 camPos = mainCam.transform.position;
			float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
			float offsetY = Random.value * shakeAmount * 2 - shakeAmount;
			camPos.x += offsetX;
			camPos.y += offsetY;

			mainCam.transform.position = camPos;


		}
	}

	void StopShake(){

		CancelInvoke ("BeginShake");


	}
}
