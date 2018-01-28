using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

	public float moveSpeed = 5.0f;
	public float rotateSpeed = 100.0f;

	void Update ()
	{
		Movement();

	}

	void Movement ()
	{

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Debug.Log("Left arrow pressed. Should rotate.");

			this.transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			Debug.Log("The Right Arrow is pressed and therefore should rotate to the right.");

			this.transform.Rotate(new Vector3(0, 0, -rotateSpeed * Time.deltaTime));
		}

		/*if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        } */

		if (Input.GetKey(KeyCode.Space))
		{
			this.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
		}
		/*
		else if (Input.GetKey(KeyCode.S))
		{
			this.transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
		}
		*/
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Obstacle"))
			moveSpeed = 2.0f;
			StartCoroutine ("WaitTwoSeconds");
	}
		

	IEnumerator WaitTwoSeconds()
	{
		yield return new WaitForSeconds (2);
		moveSpeed = 5.0f;
	}
}
