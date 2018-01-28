using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFan : MonoBehaviour {

	public AudioSource lootSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
			lootSound.Play ();
		Destroy(gameObject);

	}
}
