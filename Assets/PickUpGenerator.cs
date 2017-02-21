using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGenerator : MonoBehaviour {

	public static int Score = 0;

	public GameObject resource;
	public static int numPickUps = -1;
	public GameObject[] pickups;

	// Use this for initialization
	void Start () {
		pickups = new GameObject[49];
		int x = 0;
		for (float i = -2.5f; i <= 2.5f; i += 2f) {
			for (float j = -2.5f; j <= 2.5f; j += 2f) {
				pickups [x] = Instantiate(resource, new Vector3 (i, 0, j), Quaternion.identity) as GameObject;
				pickups [x].transform.parent = this.transform;
				pickups [x].name = "Pickup";
				x++;
			}
		}
		numPickUps = x;
	}

	private int randomInt (int min, int max) {
		return ((int)(Random.value * 100000000) % (max - min)) + min;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		if (numPickUps - Score != 0)
			GUI.Label(new Rect(10, 10, 300, 20), "Pick-ups remaining: " + (numPickUps - Score));
		else
			GUI.Label(new Rect(10, 10, 300, 20), "Done! Go to Goal");
	}
}
