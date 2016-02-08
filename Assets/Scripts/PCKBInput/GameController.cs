using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private PauseGame pauseGame = new PauseGame ();

	public GameObject playArea;

	public GameObject pauseMenuPanel;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape) && !pauseGame.IsGamePaused()) {
			playArea.SetActive (false);
			pauseMenuPanel.SetActive (true);
			pauseGame.SetPauseGame ();
		}

//		print (pauseMenuPanel.activeInHierarchy.ToString () + pauseGame.IsResetSet() + Input.GetKey(KeyCode.Escape) );

//		if (Input.GetKey (KeyCode.Escape) && pauseMenuPanel.activeInHierarchy) {
//			pauseMenuPanel.SetActive (false);
//
//			playArea.SetActive (true);
//
//			pauseGame.ResumeGame ();
//		}

	}
}
