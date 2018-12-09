using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {
	private playerController thePlayer;
	private PauseMenu thePauseMenu;

	public bool vibration;
	//public GameObject glow;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType < playerController> ();
		thePauseMenu=FindObjectOfType < PauseMenu> ();
		vibration = false;
	}

	// Update is called once per frame
	void Update () {

	}
	public void Jump(){

		if (thePlayer.grounded == true) {

			thePlayer.Jump ();///playercontroller er jump k call

		}

	}
	public void Left(){
		thePlayer.Move(-1);


	}
	public void unpressed(){
		thePlayer.Move(0);


	}
	public void Right(){

		thePlayer.Move(1);
	}
	public void Crouch(){
		thePlayer.CrouchFunction();

		//Debug.Log ("alu");

	}
	public void noCrouch(){
		thePlayer.CrouchFunction();


	}
	public void Shoot(){
		//Debug.Log ("alu");

		thePlayer.Shoot();
	
	}
}
