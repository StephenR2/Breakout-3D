/* Stephen Randall
 * 03/16/18
 * This script is responsible for t, instantiating brick particles and destorying bricks
 */
using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public GameObject brickParticle;

	void OnCollisionEnter (Collision other) // What happens upon collision with game object brick, brick particle.
	{
		Instantiate(brickParticle, transform.position, Quaternion.identity);
		GM.instance.DestroyBrick();
		Destroy(gameObject); // Destroys the brick
	}
}