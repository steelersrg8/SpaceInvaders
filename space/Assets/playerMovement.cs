using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Vector2 dir = new Vector2(h, v);
		GetComponent<Rigidbody2D> ().velocity = dir.normalized * speed;

		GetComponent<Animator> ().SetBool ("newBool", v > 0);

	}
}
