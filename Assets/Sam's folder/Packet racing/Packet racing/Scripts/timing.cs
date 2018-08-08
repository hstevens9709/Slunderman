using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timing : MonoBehaviour {
	float timer = 0f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 7f) {
			Application.LoadLevel (0);
			timer = 0;
		}	
	}
}
