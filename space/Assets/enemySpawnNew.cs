using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnNew : MonoBehaviour {

	public Transform enemy1;
	public Transform enemy2;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnEnemy", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnEnemy() {
        
		float randType = Random.Range (-1.0f, 1.0f);
		float randX = Random.Range (-5.0f, 5.0f);

		if (randType >= 0.0f) {
			Instantiate (enemy1, new Vector3 (randX, 4.0f, 0.0f), Quaternion.identity);
		} else {
			Instantiate (enemy2, new Vector3 (randX, 4.0f, 0.0f), Quaternion.identity);
		}

	}
}
