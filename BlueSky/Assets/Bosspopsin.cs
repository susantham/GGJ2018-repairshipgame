using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosspopsin : MonoBehaviour {

	public float yMax;
	public float speed;

	void Update() {
		Vector3 target = new Vector3(transform.position.x, yMax, transform.position.z);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);
	}
}