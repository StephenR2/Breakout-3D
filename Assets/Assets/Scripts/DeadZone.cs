/* Stephen Randall
 * 03/16/18
 * This script is responsible for defining what happens when object hits dead zone / water
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

	void OnTriggerEnter (Collider col) // What happens when any object collides with "DeadZone" or water.
	{
		GM.instance.LoseLife (); // Subtract life.
	}
}
