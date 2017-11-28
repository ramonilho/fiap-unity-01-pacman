using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public float velocity = 0;
	
	void Start () {
		// Puts at specific position
		//transform.position = new Vector2 (-5.0f, -2.0f);

		// Translates gradually
		//transform.Translate (0.0f, 0.0f, 0.0f);

		// Rotates gradually
		//transform.Rotate (Vector3.back * velocity * Time.deltaTime);
	}


	void Update () {
		float horizontalAxis = Input.GetAxis ("Horizontal");
		float verticalAxis = Input.GetAxis ("Vertical");

		// Translation
		float moveX = horizontalAxis * velocity * Time.deltaTime;
		float moveY = verticalAxis * velocity * Time.deltaTime;

		transform.Translate (moveX, moveY, 0f);
	}

}
