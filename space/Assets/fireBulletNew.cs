using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBulletNew : MonoBehaviour {

	public GameObject newBullet1;
	bool bulletFired = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Fire1") > 0.0f) {
			if (bulletFired == false) {
				GameObject g = (GameObject)Instantiate (newBullet1, transform.position, Quaternion.identity);
				Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());

				bulletFired = true;
				Invoke ("resetBulletFired", 0.3f);
			}
		}
	}

	void resetBulletFired() {
		bulletFired = false;
	}
}
