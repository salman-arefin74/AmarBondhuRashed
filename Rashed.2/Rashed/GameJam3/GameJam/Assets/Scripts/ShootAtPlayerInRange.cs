using UnityEngine;
using System.Collections;

public class ShootAtPlayerInRange : MonoBehaviour {

	public float playerRange;
	public GameObject enemyFire;
	public playerController player;
	public Transform launchPoint;
	public float waitBetweenShots;
	private float shotCounter;
	private Animator anim;



	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playerController> ();
		shotCounter = waitBetweenShots;
		anim = GetComponent<Animator> ();
	}


	// Update is called once per frame
	void Update () {
		if (anim.GetBool("EnemyAttack"))
			anim.SetBool("EnemyAttack", false);
		Debug.DrawLine(new Vector3(transform.position.x-playerRange,transform.position.y,transform.position.z),new Vector3(transform.position.x+playerRange,transform.position.y,transform.position.z));
		shotCounter -= Time.deltaTime;
		if(player.hidden==false){
		if (transform.localScale.x > 0 && (transform.localScale.y/2)<player.transform.position.y && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter<0) {
			Instantiate (enemyFire, launchPoint.position, launchPoint.rotation);
			anim.SetBool ("EnemyAttack", true);
			shotCounter = waitBetweenShots;

		}
		if (transform.localScale.x < 0 && (transform.localScale.y/2)<player.transform.position.y && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter<0) {
			Instantiate (enemyFire, launchPoint.position, launchPoint.rotation);
			anim.SetBool ("EnemyAttack", true);
			shotCounter = waitBetweenShots;

		}
        }
        
	}
}
