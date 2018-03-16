/* Stephen Randall
 * 03/16/18
 * This script is responsible for position of paddle, speed of paddle, etc.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle: MonoBehaviour {
	public float paddleSpeed = 1f; // Sets paddle move speed
	private Vector3 playerPos = new Vector3 (0,-9.5f,0); // Where paddle spawns

	// Update is called once per frame
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed); // Sets position and what axis it moves on
		playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 0f);
		transform.position = playerPos; // Set ball to follow paddle
	}
}
