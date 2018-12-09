using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropedestroy : MonoBehaviour {
	public int ropehealth;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (ropehealth <= 0) {
			Destroy (gameObject);
		}
	}
	public void RopeDamage (int damageToGive){

		ropehealth -= damageToGive;
	}
}
