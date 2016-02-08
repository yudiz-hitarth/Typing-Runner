using UnityEngine;
using System.Collections;

using System.Text;

using UnityEngine.UI;

public class GetRandomWord : MonoBehaviour {

	private WordDictClass words = new WordDictClass ();

	public Text typeThis;

	public Text typeDThis;

	private StringBuilder type = new StringBuilder ();

	private StringBuilder typeD = new StringBuilder ();

	private int randIndex;

	private PauseGame pauseGame = new PauseGame();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!pauseGame.IsResetSet ()) {
			if (Input.inputString.Length > 0 && !pauseGame.IsGamePaused ()) {
				foreach (char i in Input.inputString) {
					if (i.Equals (type [0]) || i.Equals (type [0].ToString ().ToUpper () [0])) {
						typeD.Append (type [0]);
						type.Remove (0, 1);

						UpdateTexts ();
					}
				}
			} 

//			typeThis.gameObject.SetActive (false);
//			typeDThis.gameObject.SetActive (false);
		} else {
//			print (pauseGame.IsResetSet ());
			type.Remove (0, type.Length);
			typeD.Remove (0, typeD.Length);	
		}

		if (type.Length <= 0 && !pauseGame.IsGamePaused ()) {
			GetNewRandIndex ();
		}
	}
//		print ("IN here" + type.Length.ToString() + "\t" + pauseGame.IsGamePaused().ToString());


	private void GetNewRandIndex(){

		randIndex = Random.Range (1, words.GetDictSize());

		type = words.GetWord (randIndex) as StringBuilder;

		typeD.Remove(0,typeD.Length);

		UpdateTexts ();

	}

	private void UpdateTexts(){
		typeThis.text = "Type This:\n" + type.ToString ();
		typeDThis.text = "Typed This:\n" + typeD.ToString ();
	}
}
