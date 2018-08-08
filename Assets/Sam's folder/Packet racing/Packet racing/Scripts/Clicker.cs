using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Clicker : MonoBehaviour {
	public GameObject loadingImage;
	public Text loadingText;
	float timer=0f;
	public float gazeTime=2f;
	public int level = 1;
	bool gaze=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gaze) {
			timer += Time.deltaTime;
			if (timer >= gazeTime) {
				timer = 0f;
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
			}
		} else {
			timer = 0f;
		}
	}

	public void PointerEnter() {
		gaze = true;
	}

	public void PointerExit() {
		gaze = false;
	}

	public void PointerDown() {
		Debug.Log ("HI!");
		//loadingText.text = "Loading level " + level;
		loadingImage.SetActive (true);
		Application.LoadLevel (level);
	}
}
