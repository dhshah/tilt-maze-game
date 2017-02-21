using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	private Rigidbody rb;

	public bool hasWon = false;

  void Start() {
      rb = GetComponent<Rigidbody>();
  }

	// Update is called once per frame
	void Update () {
		if (hasWon && PickUpGenerator.numPickUps - PickUpGenerator.Score == 0) {
			transform.Translate(0f, 0.1f, 0f);
			if (transform.position.y > 15) {
				Destroy(gameObject);
			}
		}

		if (Input.GetAxis ("Jump") > 0.2f) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 40, 0));
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Goal") {
			rb.isKinematic = true;
			hasWon = true;
		}

		if (other.name == "Pickup") {
			Destroy (other.gameObject);
			PickUpGenerator.Score++;
		}
	}
}
