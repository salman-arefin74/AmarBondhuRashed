using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageShow : MonoBehaviour {
	public LevelManager levelManager;
	public bool isImgOn;
	public Image img;
	public Checkpoint ck;
	//public bool dekhao;
	void Start () {
		ck = FindObjectOfType<Checkpoint> ();
		img.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (ck.flag) {
			
				img.enabled = true;
				isImgOn = true;
			} else {
				img.enabled = false;
				isImgOn = false;
			}
		}
		
	}



	

	

