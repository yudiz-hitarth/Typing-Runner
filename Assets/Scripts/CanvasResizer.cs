using UnityEngine;
using System.Collections;

public class CanvasResizer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
	}

}
