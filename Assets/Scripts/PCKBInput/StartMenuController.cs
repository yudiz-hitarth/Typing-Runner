using UnityEngine;
using System.Collections;

public class StartMenuController : MonoBehaviour {

	public GameObject startGamePanel;

	public GameObject selectLevelPanel;

	public GameObject exitGamePanel;

	public GameObject playArea;

	public GameObject pauseGamePanel;

	public GameObject mainMenuPromptPanel;

	private GameObject previousPanel;// = new GameObject();

	private PauseGame pauseGame = new PauseGame ();
	// Use this for initialization
	void Start () {
		pauseGame.SetPauseGame ();
		ViewMainMenu ();
	}

	public void ViewMainMenu(){
		startGamePanel.SetActive (true);
		selectLevelPanel.SetActive (false);
		exitGamePanel.SetActive (false);
		playArea.SetActive (false);

		pauseGamePanel.SetActive (false);
		mainMenuPromptPanel.SetActive (false);
	}

	public void ViewLevelMenu(){
		startGamePanel.SetActive (false);
		selectLevelPanel.SetActive (true);
		exitGamePanel.SetActive (false);
		playArea.SetActive (false);
	}


	public void ViewExitMenu(){
		startGamePanel.SetActive (false);
		selectLevelPanel.SetActive (false);

		exitGamePanel.SetActive (true);

		playArea.SetActive (false);
		pauseGamePanel.SetActive (false);
	}


	public void NoMenus(){
		startGamePanel.SetActive (false);
		selectLevelPanel.SetActive (false);
		exitGamePanel.SetActive (false);
		playArea.SetActive (false);

		mainMenuPromptPanel.SetActive (false);
		pauseGamePanel.SetActive (false);
	}

	public void StartGame(){
		pauseGame.ResumeGame ();
		playArea.SetActive (true);
	}

	public void ExitInPlay(){
		previousPanel = pauseGamePanel;
		ViewExitMenu ();
	}

	public void ExitInMain(){
		previousPanel = startGamePanel;
		ViewExitMenu ();
	}

	public void NoExit(){
		NoMenus ();
		if (previousPanel == null) {
			previousPanel = pauseGamePanel;
			pauseGame.ResumeGame ();
		}
		previousPanel.SetActive (true);
		previousPanel = null;
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void ReturnToMain(){
		pauseGamePanel.SetActive (false);
		mainMenuPromptPanel.SetActive (true);
	}

	public void YesMain(){
		mainMenuPromptPanel.SetActive (false);
		NoMenus ();
		pauseGame.ResetGame ();
		
		startGamePanel.SetActive (true);
	}

	public void NoMain(){
		mainMenuPromptPanel.SetActive (false);
		pauseGamePanel.SetActive (true);
	}

	public void ReturnToGame(){
		NoMenus ();

		playArea.SetActive (true);
		pauseGame.ResumeGame ();
	}
}
