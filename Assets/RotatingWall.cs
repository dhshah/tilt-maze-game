using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWall : MonoBehaviour {

	private static int randomInt (int min, int max) {
		return ((int)(Random.value * 100000000) % (max - min + 1)) + min;
	}

	// Use this for initialization
	void Start () {
		StartCoroutine(RotateMe());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator RotateMe() {
		int inTime = 1;
		while (true) {
			var fromAngle = transform.rotation;
			Vector3 byAngles = new Vector3 (fromAngle.x, randomInt (-1, 1) * 90, fromAngle.z);
			var toAngle = Quaternion.Euler (transform.eulerAngles + byAngles);
			for (var t = 0f; t < 1; t += Time.deltaTime / inTime) {
				transform.rotation = Quaternion.Lerp (fromAngle, toAngle, t);
				yield return null;
			}
			yield return new WaitForSecondsRealtime (randomInt (2, 5));
		}
	}
}
