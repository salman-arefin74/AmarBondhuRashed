using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour {

	public BoxCollider2D stand;
	public BoxCollider2D crouch;
	public CircleCollider2D circle;

	public playerController player;
	void Start () {
		player = GetComponent<playerController> ();
		stand.enabled = true;
		crouch.enabled = false;
		circle.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.grounded == false) {
			stand.enabled = true;
			crouch.enabled = false;
			circle.enabled = false;
		
		} else {
			if (player.crouching == true) {
				stand.enabled = false;
				crouch.enabled = true;
				circle.enabled = false;
			
			} else {
				stand.enabled = true;
				crouch.enabled = false;
				circle.enabled = true;
			}
		}
		
	}
}
