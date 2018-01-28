using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOneWay : MonoBehaviour {

	void Update () {

		transform.Rotate(new Vector3(0, 0, Random.Range(15,60)) * Time.deltaTime);
    }
}
