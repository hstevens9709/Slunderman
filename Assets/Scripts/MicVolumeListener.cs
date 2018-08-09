using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicVolumeListener : MonoBehaviour {

    private float sensitivity = 100;
    private float volume = 0;
    private float threshold = 8;

    AudioSource src;

	// Use this for initialization
	void Start () {
        src = GetComponent<AudioSource>();
        src.clip = Microphone.Start(null, true, 10, 44100);
        src.loop = true;
        src.mute = true;
        while (!(Microphone.GetPosition(null) > 0)) { }
        src.Play();
	}
	
	// Update is called once per frame
	void Update () {
        volume = getAveragedVolume() * sensitivity;
        if(volume > threshold)
        {
            // Do something
        }
	}

    private float getAveragedVolume()
    {
        float[] data = new float[256];
        float total = 0;
        src.GetOutputData(data, 0);
        foreach(float f in data)
        {
            total += Mathf.Abs(f);
        }
        return total / 256;
    }
}
