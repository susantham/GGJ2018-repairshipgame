using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrusters : MonoBehaviour {

	public Renderer rend; 
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rend.enabled = true;
		} else {
			rend.enabled = false;
		}
	}
}
