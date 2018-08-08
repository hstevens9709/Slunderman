using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker : MonoBehaviour {

	public GameObject blinker;
	public int period=100;
	private int counter=0;
	private bool nextstatus;

	void Start () {
		nextstatus = !blinker.activeSelf;
	}

	// Update is called once per frame
	void Update () {
		counter = (counter + 1) % period;
		if (counter == 0)
		{
			blinker.SetActive (nextstatus);
			nextstatus = !nextstatus;
		}
	}
}
