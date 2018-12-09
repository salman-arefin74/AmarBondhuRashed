using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarController : MonoBehaviour {
	public float speed;
	public int bullet=5;
	public playerController player;
	/*public GameObject enemyDeathEffect;
	public GameObject impactEffect;
	public int pointsForKill;
	public int damageToGive;*/
	public int damageToGive;
	//public float rotationSpeed;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playerController> ();
		if (player.transform.localScale.x < 0) {
			speed = -speed;
			//rotationSpeed = -rotationSpeed;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

		//GetComponent<Rigidbody2D> ().angularVelocity = rotationSpeed;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			
			//Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			//ScoreManager.AddPoints (pointsForKill);

			other.GetComponent<EnemyHealthManager> ().GiveDamage (damageToGive);
		}
		if (other.tag == "rope") {

			//Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			//ScoreManager.AddPoints (pointsForKill);

			other.GetComponent<Ropedestroy> ().RopeDamage (damageToGive);
		}
		
		Destroy (gameObject);

	}
}
