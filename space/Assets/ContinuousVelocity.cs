using UnityEngine;
using System.Collections;

public class ContinuousVelocity : MonoBehaviour {

	//The velocity
	public Vector2 velocity;

	//Update physics engine
	void FixedUpdate() {
		GetComponent<Rigidbody2D> ().velocity = velocity;
	}

}
