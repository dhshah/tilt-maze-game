using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

	public float maxRotation = 10f;
	public float speed = 0.5f;
	public Vector3 currentRot;

	public float xRot = 0f;
	public float zRot = 0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		currentRot = GetComponent<Transform>().eulerAngles;

		if (zRot > -maxRotation && Input.GetAxis("Horizontal") > 0.2f) {
			zRot -= speed;
		}
		if (zRot < maxRotation && Input.GetAxis("Horizontal") < -0.2f) {
			zRot += speed;
		}
		if (xRot < maxRotation && Input.GetAxis("Vertical") > 0.2f) {
			xRot += speed;
		}
		if (xRot > -maxRotation && Input.GetAxis("Vertical") < -0.2f) {
			xRot -= speed;
		}

		transform.eulerAngles = new Vector3(xRot, 0, zRot);
	}

	private float getDiff(float deg) {
		if (deg > 180f)
			return 360f - deg;
		else
			return deg;
	}

}
