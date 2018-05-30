using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : PlayerPlatformerController {

	public Slider healthBar;

	// Use this for initialization
	void Start () {
		healthBar = GetComponent<Slider> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {

		healthBar.value = currentHealth;
		
	}
}
