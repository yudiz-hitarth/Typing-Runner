using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
using System.Text;

using UnityEngine.UI;

public class RandomFourLetterWord : MonoBehaviour {

	public AlphabetsDictClass alphas = new AlphabetsDictClass();

	public Text typeThis;

	public Text typedThis;

	private StringBuilder typed = new StringBuilder ();

	public string _4Chars = "";

	public int[] randArray = {0, 1, 2, 3}; //new int[4]; 

//	randArray[] = ;

	// Use this for initialization
	void Start () {
		int RandIndex = Random.Range (1, 26);
		print (randArray [2]);
		GetNewRandNumForArr ();
		print (alphas.GetChar (RandIndex) + RandIndex.ToString());
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.inputString.Length > 0) {
			if (Input.inputString [0] == _4Chars [0]) {
				typed.Append (Input.inputString [0]);
				_4Chars = _4Chars.Substring (1);
				UpdateText ();

				if (_4Chars.Length <= 0)
					GetNewRandNumForArr ();

			}
		}
	
	}



	private void GetNewRandNumForArr(){

		var new_4Chars = new StringBuilder ();

		for(int x = 0; x < 4; x++){
			randArray[x] = Random.Range (1, 26);
//			print (randArray[x]);
			new_4Chars.Append ( alphas.GetChar(randArray[x]) );
		}

		_4Chars = new_4Chars.ToString ();

		typed.Remove (0, typed.Length);

		UpdateText ();

//		print (randArray.ToString() + "\t" + _4Chars);
	}

	private void UpdateText(){
		typeThis.text = "Type This: \n" + _4Chars;
		typedThis.text = "Typed This: \n" + typed.ToString ();
	}
}
