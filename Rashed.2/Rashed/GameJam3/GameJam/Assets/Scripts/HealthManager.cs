using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

	public static int playerHealth;
	public int maxPlayerHealth;

	private LevelManager levelManager;
	public bool isDead;
	//public Slider healthBar;
	//private LifeManager lifeSystem;

	void Start () {
		
		//healthBar=GetComponent<Slider>();
		playerHealth = maxPlayerHealth;
		levelManager = FindObjectOfType<LevelManager>();
		//lifeSystem = FindObjectOfType<LifeManager> ();
		isDead = false;
	}


	void Update () {
		if (playerHealth <= 0 && !isDead) {
			playerHealth = 0;
			levelManager.RespawnPlayer ();
		//	lifeSystem.TakeLife ();
			isDead = true;
		}
		if (playerHealth > maxPlayerHealth) {
			playerHealth = maxPlayerHealth;
		}

	//	healthBar.value=playerHealth;
	}
	public static void HurtPlayer(int damageToGive){

		playerHealth -= damageToGive;
	}
	public void FullHealth(){
		playerHealth = maxPlayerHealth;

	}
}
