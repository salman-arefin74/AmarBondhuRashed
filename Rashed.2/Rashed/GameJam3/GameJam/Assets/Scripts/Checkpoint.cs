using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public LevelManager levelManager;
	public bool flag;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
		flag = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.L)) {
			flag = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {

			levelManager.currentCheckpoint = gameObject;
			Debug.Log ("hello fdsf Activated Checkpoint" + transform.position);
			//flag = true;
			 
				//flag = true;


		}



	}
	/*void OnTriggerExit2D(Collider2D other){
		if (other.name == "Player") {

			flag = false;

		}
	}*/
		



	


}
