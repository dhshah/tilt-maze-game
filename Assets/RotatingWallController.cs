using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWallController : MonoBehaviour {

	public static int MIN_WALLS = 10;
	public static int MAX_WALLS = 15;
	private GameObject[] walls;

	public GameObject resource;
	public int numWalls = 0;

	// Use this for initialization
	void Start () {
		numWalls = randomInt (MIN_WALLS, MAX_WALLS);
		walls = new GameObject[49];
		int x = 0;
		for (int i = -3; i <= 3; i += 2) {
			for (int j = -3; j <= 3; j += 2) {
				walls [x] = Instantiate(resource, new Vector3 (i, 0, j), Quaternion.identity) as GameObject;
				walls [x].transform.parent = this.transform;
				x++;
			}
		}
	}

	private int randomInt (int min, int max) {
		return ((int)(Random.value * 100000000) % (max - min)) + min;
	}

	// Update is called once per frame
	void Update () {

	}
}
