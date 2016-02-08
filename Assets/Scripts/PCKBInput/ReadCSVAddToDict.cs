using UnityEngine;
using System.Collections;

//using FileHelpers;

using System.IO;

public class ReadCSVAddToDict : MonoBehaviour {

	private WordDictClass wordDict = new WordDictClass ();

//	private string fileName;

	private PauseGame pauseGame = new PauseGame();

	private TextAsset _XLetterWords; //= new TextAsset();

//	private int counter = 1;

//	[DelimitedRecord("\n")]
//	private class Word
//	{
//		public string word;
//	}

	// Use this for initialization
	void Start () {

//		_XLetterWords = Resources.Load ("_4LetterWords") as TextAsset;

//		print (_XLetterWords.text);
//		File letterWordfiles = Resources.LoadAll ("") as File;
//		var engine = new FileHelperEngine<Word> ();

//		var result = engine.ReadFile ("./DataBase/_4LetterWords.csv");
	}

	public void GetFileName(string sentFileName){
//		fileName = sentFileName;
		pauseGame.ResetGame();

		try{
			wordDict.ResetDictionary();
		}

		catch{
//			Debug.Log ("Word Dictionary Empty");
		}

		_XLetterWords = Resources.Load (sentFileName) as TextAsset;

//		string[] lines = System.IO.File.ReadAllLines (@"./Assets/DataBase/" + fileName + ".txt");//_4LetterWords.txt");

//		Debug.Log (_XLetterWords.text.Split('\n').ToString());

		using (StringReader reader = new StringReader(_XLetterWords.text))
		{
			string line;
			while ((line = reader.ReadLine ()) != null) {
//			foreach (string line in _XLetterWords.text.Split('\n')) {
//				//			print (line.ToLower());
//				if (!line.Equals ('\n'))
					wordDict.AddDictElement (line.Substring (0, (line.Length)).ToLower ());

	//			print (line);

	//			print (wordDict.GetWord (counter++));
			}
		}
//		Debug.Log ("Done" + wordDict.GetDictSize().ToString());

		Resources.UnloadAsset (_XLetterWords);

		pauseGame.ResetGameDone ();

	}

}
