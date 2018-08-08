using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.Euler (-10, 180, 0);
		Debug.Log ("HI!SFAJKLFHL");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
