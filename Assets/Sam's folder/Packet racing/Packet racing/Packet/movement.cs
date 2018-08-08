using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float speed = 2f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		//speed += 0.001f;
	}
}
