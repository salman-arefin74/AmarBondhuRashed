using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool grounded;
//	private bool doubleJumped;
	private Animator anim;
	private float moveVelocity;
	public Transform firePoint;
	public GameObject ninjaStar;
	public bool onLadder;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;
	public int bullet;
	public Transform CeilPoint;
	private bool ceiled;
	private float crouch;
	public bool crouching;
	public GameObject hideout;
	public bool hidden;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		gravityStore = GetComponent<Rigidbody2D>().gravityScale;
		bullet = 5;
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
		ceiled = Physics2D.OverlapCircle (CeilPoint.position, groundCheckRadius, whatIsGround);


	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().isKinematic = false;

		crouch = Input.GetAxisRaw ("Crouch");
		//if (grounded)
		//	doubleJumped = false;
		anim.SetBool ("Crouch", crouching);
		anim.SetBool ("Grounded", grounded);
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
			Jump();
		}
		/*
		if (Input.GetKeyDown (KeyCode.Space)&& !doubleJumped && !grounded) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
			Jump();
			doubleJumped = true;
		}
		*/
		moveVelocity = 0f;
		//Move(Input.GetAxisRaw("Horizontal"));

		if (Input.GetKey (KeyCode.D)) {
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			moveVelocity=moveSpeed;
		}
		if (Input.GetKey (KeyCode.A)) {
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			moveVelocity=-moveSpeed;
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

		anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x));

		if (GetComponent<Rigidbody2D> ().velocity.x>0) {
			transform.localScale = new Vector3 (1f, 1f, 1f);

		} else if(GetComponent<Rigidbody2D> ().velocity.x<0){
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
		if (anim.GetBool("Attack"))
			anim.SetBool("Attack", false);
		//Move (Input.GetAxisRaw ("Horizontal"));

			
		//
		//if (Input.GetMouseButtonDown(0))
		if(Input.GetKeyDown(KeyCode.Z)){
			Shoot();
			//Fire();
			}


		Ladder ();
		CrouchFunction ();

		//if(anim.GetBool("push"))
		//	anim.SetBool("push", false);

		
	}

	public void Jump(){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
	}

	public void Shoot(){
		if (FindObjectOfType<LevelManager> ().bullet > 0) {
			FindObjectOfType<LevelManager> ().Takebullet();

			anim.SetBool ("Attack", true);
			Instantiate (ninjaStar, firePoint.position, firePoint.rotation);


			//Debug.Log (bullet);

		}
	}
	public void Ladder(){
		if (onLadder) {
			
			GetComponent<Rigidbody2D> ().gravityScale = 0f;
			climbVelocity = climbSpeed * Input.GetAxisRaw ("Vertical");
			anim.SetBool("Climb", true);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, climbVelocity);

		}
		if (!onLadder) {
			anim.SetBool("Climb", false);
			GetComponent<Rigidbody2D> ().gravityScale = gravityStore;
		}


	}

	public void OnCollisionEnter2D(Collision2D other){
		if(other.transform.tag=="MovingPlatform"){
			transform.parent=other.transform;
		}

	}
	public void OnCollisionExit2D(Collision2D other){
		if(other.transform.tag=="MovingPlatform"){
			transform.parent=null;
		}

	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "pushable") {
			
			anim.SetBool ("push", true);
			//Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			//ScoreManager.AddPoints (pointsForKill);

		} 
		if (other.tag == "Hideout") {
			
			hidden = true;
			GetComponent<Rigidbody2D> ().isKinematic = true;
			Physics2D.IgnoreLayerCollision (12, 13, true);
		} 

	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "pushable") {

			anim.SetBool ("push", false);
			//Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			//ScoreManager.AddPoints (pointsForKill);

		}
        if (other.tag == "Hideout")
        {

            hidden = false;
            GetComponent<Rigidbody2D>().isKinematic = false;
            //Physics2D.IgnoreLayerCollision(12, 13, true);
        }



    }

	public void CrouchFunction(){
		if (crouch != 0 && grounded == true) {
			crouching = true;
		} else {
			crouching = false;
		}
	
	}

	public void Move(float moveInput){
		moveVelocity = moveSpeed * moveInput;
	}


}
