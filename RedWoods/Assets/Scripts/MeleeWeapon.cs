using UnityEngine;
using System.Collections;

public class MeleeWeapon : MonoBehaviour {

	float damage;
	float attackDelay;
	float range;
	float arc;
	float nextAttack = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Attack () {
		//check if we can attack
		if (Time.time > nextAttack) {
			//make hurtbox
				//attach the collider
				
				//move the center and resize the collider
			//set new attack time
			nextAttack = Time.time + attackDelay;
		}
	}
}
