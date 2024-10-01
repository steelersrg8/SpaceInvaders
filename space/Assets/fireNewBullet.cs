using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireNewBullet : MonoBehaviour {

	public Transform newBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxisRaw("Jump") > 0.0f) {
			Instantiate (newBullet, transform.position, Quaternion.identity);
		}

	}
}
