using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour {

	public string startLevel;
	public string Menu;

	public string storyLevel;
	public string storyLevel1;
	public string storyLevel2;
	public string storyLevel3;
	public string storyLevel4;
	public string storyLevel5;
	public string storyLevel6;

	public void StartGame(){
		Application.LoadLevel (startLevel);
	}
	public void Story(){
		Application.LoadLevel (storyLevel);
	}
	public void Story1(){
		Application.LoadLevel (storyLevel1);
	}
	public void Story2(){
		Application.LoadLevel (storyLevel2);
	}
	public void Story3(){
		Application.LoadLevel (storyLevel3);
	}
	public void Story4(){
		Application.LoadLevel (storyLevel4);
	}
	public void Story5(){
		Application.LoadLevel (storyLevel5);
	}
	public void Story6(){
		Application.LoadLevel (storyLevel6);
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void quit(){
		Application.LoadLevel (Menu);
	}


}
