using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker_move : MonoBehaviour {
	float counter = 0f;
	float counter2 = 1f;
	public float speed = 2f;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		transform.position = transform.position + new Vector3 (0, 0, counter2 * Time.deltaTime * speed);
		if (counter > 1	){
			counter2 = -counter2;
			counter = 0;
		}
	}
}
