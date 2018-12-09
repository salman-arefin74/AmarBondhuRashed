using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public string MainMenu;
	public bool isPaused;
	public GameObject pauseMenuCanvas;

	void Update () {
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);

		} else {
			pauseMenuCanvas.SetActive (false);

		}
			
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}
	}

	public void resume(){
		isPaused = false;
	}
	public void quit(){
		Application.LoadLevel (MainMenu);
	}
}
