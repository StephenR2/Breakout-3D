/* Stephen Randall
 * 03/16/18
 * This script is responsible for ball, putting ball in play, etc.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float ballInitialVelocity = 600f; // Sets balls velocity
	private Rigidbody rb; 
	private bool BallInPlay; // Flag for when the ball is in play.

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> (); // Makes it a rigidbody

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && BallInPlay == false) { // If clicked and Ball is not already in play put into play.
			transform.parent = null;
			BallInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));

		}
			
	}
}
