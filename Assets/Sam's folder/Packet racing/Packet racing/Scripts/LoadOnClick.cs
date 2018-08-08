using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public GameObject loadingImage;
	public Text loadingText;

	public void LoadScene(int level)
	{
		loadingText.text = "Loading...";
		loadingImage.SetActive (true);
		Application.LoadLevel (level);
	}
}