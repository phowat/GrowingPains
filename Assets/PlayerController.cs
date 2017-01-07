using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float sizeJumps; 

	void FixedUpdate () {

		Vector3 currentScale = transform.localScale;
		Vector3 newScale;
		if (currentScale.x <= 0) {
			Destroy (gameObject);
		}
		if (Input.GetKey ("space")) {
			newScale = new Vector3 (
				currentScale.x + sizeJumps,
				currentScale.y + sizeJumps,
				currentScale.z + sizeJumps
			);
		} else {
			newScale = new Vector3 (
				currentScale.x - sizeJumps,
				currentScale.y - sizeJumps,
				currentScale.z - sizeJumps
			);
		}
		transform.localScale = newScale;
	}
}
