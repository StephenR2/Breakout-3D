/* Stephen Randall
 * 03/16/18
 * This script is responsible for timing of destroy for objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimedDestroy : MonoBehaviour {
	public float destoryTime = 1f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, destoryTime); // How long it takes to destory a brick.
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
