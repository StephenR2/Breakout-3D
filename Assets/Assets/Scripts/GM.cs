/* Stephen Randall
 * 03/16/18
 * This script is responsible for all things pertaining to your game, instantiating, checking for game over, moving to next scene, etc.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
	public int lives = 3; // Number of lives player has
	public int bricks = 20; // Number of bricks in game
	public float resetDelay = 1f; // Delay before resetting game.
	public Text livesText; // Text that displays live count
	public GameObject gameOver; // Displays message game over
	public GameObject youWon; // Displays message you won
	public GameObject bricksPrefab; // Holds the bricks and instantiates them on screen (The bricks)
	public GameObject paddle; // The paddle
	public GameObject deathParticles; // The death particles after brick has been broken
	public static GM instance = null;

	private GameObject clonePaddle;

	// Use this for initialization
	void Start () { // Sets game up
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		Setup ();
	}
	public void Setup(){
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject; //Instantiates paddle
		Instantiate (bricksPrefab, transform.position, Quaternion.identity); // Instantiates bricks

	}
	void CheckGameOver(){
		if (bricks < 1) { // If bricks have been destoryed go onto the next scene in line.
			//youWon.SetActive (true);
			//Time.timeScale = .25f;
			//Invoke ("Reset", resetDelay);
			//SceneManager.LoadScene("YouWon");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		if (lives < 1) { // If lives are less than zero (dead) go to gameover scene
			//gameOver.SetActive (true);
			//Time.timeScale = .25f;
			//Invoke ("Reset", resetDelay);
			SceneManager.LoadScene("GameOver");
		}
	}
	void Reset(){ //When reset button pressed, reset time, load first level.
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void LoseLife(){ // If ball out of boundary subtract life, print change, Instantiate particles on screen, Destory paddle
		lives--;
		livesText.text = "Lives: " + lives;
		Instantiate (deathParticles, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Invoke ("SetupPaddle", resetDelay); // set up paddle again
		CheckGameOver (); // Check if that was the last life or if there are more left.

	}
	void SetupPaddle(){
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject; // Sets up paddle

	}
	public void DestroyBrick(){ // When brick destroyed subtract from variable.
		bricks--;
		CheckGameOver (); // Check if that was the last brick or if there are more left.
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
