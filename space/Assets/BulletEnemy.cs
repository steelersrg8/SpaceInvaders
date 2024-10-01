using UnityEngine;
using System.Collections;

public class BulletEnemy : MonoBehaviour {
	//The Bullet Prefab
	public GameObject bullet;

	//The firing interval
	public float interval = 1;

	// Use this for initialization
	void Start () {
		//Call fire every few seconds
		InvokeRepeating("Fire", interval, interval);
	}
	

	void Fire () {
		//Spawn the bullet
		GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
		//Ignore Bullet <--> Enemy collisions
		Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), transform.parent.GetComponent<Collider2D>());
	}
}
