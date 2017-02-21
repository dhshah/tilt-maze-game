using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

	public float maxRotation = 10f;
	public float speed = 0.5f;
	public Vector3 currentRot;

	public float tiltSensitivity = 20.0f;
	public float xRot = 0f;
	public float zRot = 0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		currentRot = GetComponent<Transform>().eulerAngles;

		if (zRot > -maxRotation && Input.GetAxis("Horizontal") < 0.2f) {
			zRot += Time.deltaTime * tiltSensitivity * Input.GetAxis ("Horizontal");
		}
		if (zRot < maxRotation && Input.GetAxis("Horizontal") > -0.2f) {
			zRot += Time.deltaTime * tiltSensitivity * Input.GetAxis ("Horizontal");
		}
		if (xRot > -maxRotation && Input.GetAxis("Vertical") < 0.2f) {
			xRot += Time.deltaTime * tiltSensitivity * Input.GetAxis ("Vertical");
		}
		if (xRot < maxRotation && Input.GetAxis("Vertical") > -0.2f) {
			xRot += Time.deltaTime * tiltSensitivity * Input.GetAxis ("Vertical");
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
