using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.Text;

[System.Serializable]
public class WordDictClass : System.Object {

	static private Dictionary<int, string> words = new Dictionary<int, string> (); //{
//		{1, "a"}, {2, "b"}, {3, "c"}, {4, "d"}, {5, "e"}, 
//		{6, "f"}, {7, "g"}, {8, "h"}, {9, "i"}, {10, "j"}, 
//		{11, "k"}, {12, "l"}, {13, "m"}, {14, "n"}, {15, "o"}, 
//		{16, "p"}, {17, "q"}, {18, "r"}, {19, "s"}, {20, "t"}, 
//		{21, "u"}, {22, "v"}, {23, "w"}, {24, "x"}, {25, "y"}, 
//		{26, "z"}
//	};

	public StringBuilder GetWord (int index){
//		string value;
		return new StringBuilder( words[index]);
	}

	public void AddDictElement(string valueToAdd){
		words.Add ((words.Count + 1), valueToAdd);
	}

	public int GetDictSize(){
		return words.Count;
	}

	public void ResetDictionary(){
		words.Clear ();
	}
}
