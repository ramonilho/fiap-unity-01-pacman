using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour {

	public float velocity = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalAxis = Input.GetAxis ("Horizontal");
		float verticalAxis = Input.GetAxis ("Vertical");

		// Translation
		float moveX = horizontalAxis * velocity * Time.deltaTime;
		float moveY = verticalAxis * velocity * Time.deltaTime;

		transform.Translate (moveX, moveY, 0f);
	}
}
