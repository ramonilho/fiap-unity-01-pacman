using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

	public float velocity = 200;

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}

	void OnCollisionStay2D(Collision2D c) {
		//print ("Is colliding");
	}

	void OnCollisionExit2D(Collision2D c) {
		print("Stopped collision with " + c.gameObject.name);
	}

	void Update() {
		transform.Rotate (Vector3.back * velocity * Time.deltaTime);
	}
}
