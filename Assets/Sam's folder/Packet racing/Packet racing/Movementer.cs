using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right*0.4f);
		Debug.Log (Vector3.right*0.4f);
		//transform.position += new Vector3(0.1, 0, 0)
	}
}
