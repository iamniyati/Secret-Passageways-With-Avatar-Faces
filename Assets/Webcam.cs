using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WebCamDevice[] devices = WebCamTexture.devices;

        for (int i = 0; i < devices.Length; i++)
        {
            print("webcam: " + devices[i].name);
        }

        Renderer rend = this.GetComponentInChildren<Renderer>();
        WebCamTexture tex = new WebCamTexture(devices[0].name);
        rend.material.mainTexture = tex;
        tex.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
