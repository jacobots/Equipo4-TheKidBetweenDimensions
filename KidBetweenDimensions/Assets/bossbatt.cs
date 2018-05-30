using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossbatt : MonoBehaviour {
	public GameObject Boss;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player"){
		Boss.SetActive (true);

	}
}

}
