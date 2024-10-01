using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BulletDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		//Collision with a Ship? Then, destroy it.

		if (coll.gameObject.tag == "Ship") {
			Destroy (coll.gameObject);
            SceneManager.LoadScene(0);
		}

		if (coll.gameObject.tag == "Enemy") {
			Destroy (coll.gameObject);
			ScoreUI.AddPoint ();
		}

		//Destroy Bullet in any case
		Destroy(gameObject);

	}

}
