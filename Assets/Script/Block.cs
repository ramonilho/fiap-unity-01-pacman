using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c) {
		print("Started collision with " + c.gameObject.tag + " at position: "+c.gameObject.transform.position);

		if (c.gameObject.tag == "colliders") {
			Destroy (gameObject);
		}
			
	}

	void OnCollisionStay2D(Collision2D c) {
		//print ("Is colliding");
	}

	void OnCollisionExit2D(Collision2D c) {
		print("Stopped collision with " + c.gameObject.name);
	}

}
