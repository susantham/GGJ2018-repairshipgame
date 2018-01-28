using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject debris1;
	public GameObject debris2;
	public GameObject debris3;
	public int maxDebris = 5;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	// Use this for initialization

	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn()
	{
		for (int i = 0; i < maxDebris; i++) {

			Vector2 randomCord1 = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
			Instantiate (debris1, randomCord1, Quaternion.AngleAxis(Random.Range(-90, 90), Vector3.back));

			Vector2 randomCord2 = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
			Instantiate (debris2, randomCord2, Quaternion.AngleAxis(Random.Range(-90, 90), Vector3.back));

			Vector2 randomCord3 = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
			Instantiate (debris3, randomCord3, Quaternion.AngleAxis(Random.Range(-90, 90), Vector3.back));


		}

	}

}