using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class var_initialiser : MonoBehaviour {
	public static int ID;

	// Use this for initialization
	void Start () {
		ID = Mathf.FloorToInt((Random.Range(7f,15.9f)));
		Debug.Log (ID);
	}	
	
	// Update is called once per frame
	void Update () {
		
	}
}
