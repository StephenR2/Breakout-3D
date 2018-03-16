/* Stephen Randall
 * 03/16/18
 * This script is responsible for Managing levels, loading scene and quitting application.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public void StartGame(){
		SceneManager.LoadScene ("LevelOne"); // Loads first scene
	}
	public void QuitGame(){
		Application.Quit (); // Quits the application
	}
}
