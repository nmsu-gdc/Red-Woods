using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed = 2f;
	float startTime;
	float lifeTime = 10f;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
		if (Time.time - startTime > lifeTime) {
			Destroy(this.transform.gameObject);
		}
	}
}
