using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	public bool isFiring;
	public misil bullet;
	public float bulletSpeed;
	Animator anim;

	public float timeBetweenShots;
	private float shotCounter;

	public Transform firePoint;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isFiring) {
			anim.SetBool (("isShooting"), true);
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
				shotCounter = timeBetweenShots;
				misil newBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) as misil;
				newBullet.speed = bulletSpeed;
			}
		} else {

			shotCounter = 0;
			anim.SetBool (("isShooting"), false);
		}
	}
}
