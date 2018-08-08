﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed=1f;  // speed in degrees per frame

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * speed);
	}
}
