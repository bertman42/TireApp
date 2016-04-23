using UnityEngine;
using System.Collections;

public class Webcam_devices : MonoBehaviour {
	// Gets the list of devices and prints them to the console.
	public void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;
		for( var i = 0 ; i < devices.Length ; i++ )
			Debug.Log(devices[i].name);        
	}
}