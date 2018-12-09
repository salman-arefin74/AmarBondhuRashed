using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			//other.GetComponent<AudioSource>().Play();﻿
			FindObjectOfType<LevelManager> ().Givebullet();///hurt method call
			//Instantiate (bloodParticleObject, transform.position, transform.rotation);
			Destroy (gameObject);
		}


	}
}
