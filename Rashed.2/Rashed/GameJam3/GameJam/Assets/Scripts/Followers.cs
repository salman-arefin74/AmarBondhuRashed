using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followers : MonoBehaviour {
	public float moveSpeed;
	//public float jumpHeight;
	//public Transform groundCheck;
	//public float groundCheckRadius;
	//public LayerMask whatIsGround;
	//private bool grounded;
	//	private bool doubleJumped;
	private Animator anim;
	private float moveVelocity;
	//public Transform firePoint;
	//public GameObject ninjaStar;
	public bool onLadder;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;
	//public int bullet;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		gravityStore = GetComponent<Rigidbody2D>().gravityScale;
		//bullet = 5;
	}

	void FixedUpdate(){
		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

	}

	// Update is called once per frame
	void Update () {
		//if (grounded)
		//	doubleJumped = false;
		//anim.SetBool ("Grounded", grounded);
		/*if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
			Jump();*
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



			//Fire();



		
		//if(anim.GetBool("push"))
		//	anim.SetBool("push", false);


	}


	/*public void Ladder(){
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


	}*/



	}



