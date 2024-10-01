using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFireBullet : MonoBehaviour {

	public GameObject enemyBullet1;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("fireEnemyBullet", 0.5f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void fireEnemyBullet() {
		GameObject g = (GameObject)Instantiate (enemyBullet1, transform.position, Quaternion.identity);
		Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());
	}
}
