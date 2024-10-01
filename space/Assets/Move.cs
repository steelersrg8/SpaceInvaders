using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//Ship Speed
	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// For updating Physics Engine
	void FixedUpdate () {

		//Get Input from Arrow Keys, WSAD, Gamepads,
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		//Set the Rigidbody's Velocity
		Vector2 dir = new Vector2(h, v);
		GetComponent<Rigidbody2D> ().velocity = dir.normalized * speed;

		//Set Animation Parameter
		GetComponent<Animator>().SetBool("if flying", (v > 0));


	}
}
