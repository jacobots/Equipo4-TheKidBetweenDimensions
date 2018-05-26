using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class videololo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


			if(Input.GetButton("Jump")) {
				SceneManager.LoadScene("Cinematica");
			}

		
	}
}
