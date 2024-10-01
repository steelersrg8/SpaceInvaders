using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

	public int eHealth = 3;
	public int enemyScore = 3;

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "bullet") {
			eHealth--;
		}

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (eHealth <= 0) {
			GameManager.score += enemyScore;
			Destroy (this.gameObject);
		}
	}
}
