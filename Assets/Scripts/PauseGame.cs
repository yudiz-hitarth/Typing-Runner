using UnityEngine;
using System.Collections;


[System.Serializable]
public class PauseGame : System.Object {

	static private bool pauseGame = true;

	static private bool resetGame = true;

	public void SetPauseGame(){
		pauseGame = true;
		resetGame = false;
	}

	public void ResumeGame(){
		pauseGame = false;
		resetGame = false;
	}

	public bool IsGamePaused(){
		return pauseGame;
	}

	public void ResetGame(){
		resetGame = true;
		pauseGame = true;
	}

	public void ResetGameDone(){
		resetGame = false;
		pauseGame = false;
	}

	public bool IsResetSet(){
		return resetGame;
	}
}
