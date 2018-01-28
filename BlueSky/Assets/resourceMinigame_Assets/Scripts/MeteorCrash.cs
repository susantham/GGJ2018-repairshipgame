using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCrash : MonoBehaviour {

	public AudioSource explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
			explosion.Play ();
			Destroy(gameObject);
		
	}
}
