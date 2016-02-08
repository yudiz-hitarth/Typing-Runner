using UnityEngine;
using System.Collections;

public class MoveGO : MonoBehaviour {

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position = Vector3.MoveTowards (transform.position, new Vector3(-2, -2.63F, 0), 5F * Time.deltaTime );
		rb.velocity = new Vector2(-3, 0);
	}
	
}