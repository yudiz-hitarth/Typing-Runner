using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class BulletHit : MonoBehaviour {

//	private Text hitText;

//	private Text obstacleText;

	void Start(){
//		obstacleText = GetComponentInChildren<Text> ();
		
//		print ("here Start");
	}

	void OnCollisionEnter2D(Collision2D other){

//		Debug.Log ("Here, " + other.gameObject.tag);

		if (other.gameObject.tag.Contains ("Bullet")) {
//			hitText = other.gameObject.GetComponentInChildren<Text> ();

//			Debug.Log (hitText.text);

			Destroy (this.gameObject);

			Destroy (other.gameObject);

		}
	}

}
