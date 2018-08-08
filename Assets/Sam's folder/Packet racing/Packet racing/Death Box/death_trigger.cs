using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_trigger : MonoBehaviour {

	// default death scene is start menu
	public int deathSceneID = 0; 	

	void OnTriggerEnter(Collider other){
		Debug.Log ("object entered trigger");
		Application.LoadLevel (deathSceneID);
	}

}
