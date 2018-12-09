using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public GameObject currentCheckpoint;
	private playerController player;
	public GameObject deathParticle;
	public GameObject respawnParticle;


	public int pointPenaltyOnDeath;
	public float respawnDelay;
	private CameraController camera;
	private Checkpoint cut;

	private float gravityStore;
	public int bullet;
	public int dekhao;
	public int maxbullet;
	public GameObject bbar1;
	public GameObject bbar2;
	public GameObject bbar3;
	public GameObject bbar4;
	public GameObject bbar5;
	public GameObject bbar6;

	public GameObject cuts;
	//public HealthManager healthManager;
	// Use this for initialization
	void Start () {
		
		bbar6.SetActive (true);
		bbar5.SetActive (false);
		bbar4.SetActive (false);
		bbar3.SetActive (false);
		bbar2.SetActive (false);
		bbar1.SetActive (false);
		player = FindObjectOfType<playerController> ();
		camera = FindObjectOfType<CameraController> ();
		//healthManager = FindObjectOfType<HealthManager> ();
	}

	// Update is called once per frame
	void Update () {

	}
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");

	}

	public IEnumerator RespawnPlayerCo(){

		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		camera.isFollowing = false;
		//gravityStore=player.GetComponent<Rigidbody2D> ().gravityScale;
		//player.GetComponent<Rigidbody2D> ().gravityScale = 0f;
		//player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		//ScoreManager.AddPoints (-pointPenaltyOnDeath);
		Debug.Log ("Player Respawn");
		yield return new WaitForSeconds (respawnDelay);
		//player.GetComponent<Rigidbody2D> ().gravityScale = gravityStore;
		player.transform.position = currentCheckpoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer> ().enabled = true;
		camera.isFollowing = true;
		//healthManager.FullHealth ();
		//healthManager.isDead = false;

		Instantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
	
	}
	public void Takebullet(){
		bullet = bullet - 1;
		if (bullet == 0) 
			bbar1.SetActive (true);
		else
			bbar1.SetActive (false);
		if (bullet == 1) 
			bbar2.SetActive (true);
		else
			bbar2.SetActive (false);
		if (bullet == 2) 
			bbar3.SetActive (true);
		else
			bbar3.SetActive (false);
		if (bullet == 3) 
			bbar4.SetActive (true);
		else
			bbar4.SetActive (false);
		if (bullet == 4) 
			bbar5.SetActive (true);
		else
			bbar5.SetActive (false);
		if (bullet == 5) 
			bbar6.SetActive (true);
		else
			bbar6.SetActive (false);



	}
	public void Givebullet(){
		bullet = bullet + 3;
		if (bullet > maxbullet)
			bullet = maxbullet;
		if (bullet == 0) 
			bbar1.SetActive (true);
		else
			bbar1.SetActive (false);
		if (bullet == 1) 
			bbar2.SetActive (true);
		else
			bbar2.SetActive (false);
		if (bullet == 2) 
			bbar3.SetActive (true);
		else
			bbar3.SetActive (false);
		if (bullet == 3) 
			bbar4.SetActive (true);
		else
			bbar4.SetActive (false);
		if (bullet == 4) 
			bbar5.SetActive (true);
		else
			bbar5.SetActive (false);
		if (bullet == 5) 
			bbar6.SetActive (true);
		else
			bbar6.SetActive (false);



	}

	/*public void cutscene(){
		if (dekhao == 1) 
			image1.SetActive (true);
		else
			image1.SetActive (false);

		if (dekhao == 2) 
			image2.SetActive (true);
		else
			image2.SetActive (false);
		if (dekhao == 3) 
			image3.SetActive (true);
		else
			image3.SetActive (false);

		if (dekhao == 4) 
			image4.SetActive (true);
		else
			image4.SetActive (false);

		if (dekhao == 5) 
			image5.SetActive (true);
		else
			image5.SetActive (false);

		if (dekhao == 6) 
			image6.SetActive (true);
		else
			image6.SetActive (false);

		if (dekhao == 7) 
			image7.SetActive (true);
		else
			image7.SetActive (false);
	
	}*/
}
