using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rando_trigger : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		UnityEngine.SceneManagement.SceneManager.LoadScene (var_initialiser.ID);
		Debug.Log ("object entered trigger");
	}
}
