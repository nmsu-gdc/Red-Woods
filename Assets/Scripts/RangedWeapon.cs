using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour {

	float fireDelay = 0.2f;
	float nextFire = 0.0f;
	float reloadTime = 1f;

	float damage;
	int ammoCapacity = 15;
	int currentAmmo;
	Transform transform;
	public GameObject projectile;
	
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
		Debug.Log (transform.position.x);
		currentAmmo = ammoCapacity;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Attack () {
		if (Time.time > nextFire){
			if (currentAmmo == 0){
				nextFire = Time.time + (reloadTime - fireDelay);
				currentAmmo = ammoCapacity;
			} else {
				nextFire = Time.time + fireDelay;
				Instantiate(projectile, transform.position, Quaternion.identity); 
				currentAmmo--;
			}
		}
	}
}